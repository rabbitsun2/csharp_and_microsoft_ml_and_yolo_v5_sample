using OnnxSample.Yolov5;
using OpenCvSharp;
using System.Windows.Forms;
using Point = OpenCvSharp.Point;
using Size = OpenCvSharp.Size;

namespace YoloOpenCVSample
{
    public partial class Form1 : Form
    {
        bool isCameraOn;
        bool isRun;
        bool isZoomUp;

        Thread thread_camera, thread_video;
        Mat mat_camera;
        Mat destMat_camera;
        Mat mat_video;
        VideoCapture cameraCapture;
        VideoCapture videoCapture;

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            isRun = false;

            // PictureBox ���
            pictureCallback(this.pictureBox1, "test1.jpg");
            pictureCallback(this.pictureBox2, "test2.jpg");
            pictureCallback(this.pictureBox3, "test3.jpg");
            pictureCallback(this.pictureBox4, "test4.jpg");
            pictureCallback(this.pictureBox5, "test5.jpg");
            pictureCallback(this.pictureBox6, "test6.jpg");
            pictureCallback(this.pictureBox7, "test7.jpg");

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isRun = true;

            thread_video = new Thread(new ThreadStart(VideoCallback));
            thread_video.Start();

        }


        private void CameraCallback()
        {
            mat_camera = new Mat();
            cameraCapture = new VideoCapture(0);
            cameraCapture.Set(VideoCaptureProperties.FrameWidth, 640);
            cameraCapture.Set(VideoCaptureProperties.FrameHeight, 480);

            if (!cameraCapture.IsOpened())
            {
                MessageBox.Show("ī�޶� ���� ���߽��ϴ�.", "Ȯ��", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Yolo Detector
            var detector = new YoloDetector("best.onnx");   // Yolo v5���� ������ pt���� ����

            while (isCameraOn)
            {
                try
                {
                    cameraCapture.Read(mat_camera);

                    // n���� ����� ������� ��
                    if (mat_camera.Empty())
                        break;

                    destMat_camera = mat_camera;

                    // Gaussian ���� ����
                    Cv2.GaussianBlur(mat_camera, destMat_camera, new OpenCvSharp.Size(), (double)1);

                    // ����� ����ũ ���� ����
                    float alpha = 1f;
                    destMat_camera = (1 + alpha) * mat_camera - alpha * destMat_camera;


                    float ratio = 0.0f;
                    Point diff1 = new Point();
                    Point diff2 = new Point();
                    var letter_image = YoloDetector.CreateLetterbox(mat_camera, new Size(640, 384), new Scalar(114, 114, 114), out ratio, out diff1, out diff2);
                    var result = detector.objectDetection(mat_camera);

                    using (var dispImage = mat_camera.Clone())
                    {
                        foreach (var obj in result)
                        {
                            Cv2.Rectangle(dispImage, new Point(obj.Box.Xmin, obj.Box.Ymin), new Point(obj.Box.Xmax, obj.Box.Ymax), new Scalar(0, 0, 255), 2);
                            Cv2.PutText(dispImage, obj.Label, new Point(obj.Box.Xmin, obj.Box.Ymin - 5), HersheyFonts.HersheySimplex, 1, new Scalar(0, 0, 255), 2);
                        }

                        System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(dispImage.ToBytes());

                        // �޸� ���� ���� ����
                        if (cameraBox.Image != null)
                        {
                            cameraBox.Image.Dispose();
                        }

                        cameraBox.Image = new Bitmap(memoryStream);

                    }


                }
                catch (Exception ex)
                {

                }

            }

            Cv2.DestroyAllWindows();
        }


        private void VideoCallback()
        {

            VideoCapture video = new VideoCapture(@"D:\\sample.avi");
            mat_video = new Mat();

            // Yolo Detector
            var detector = new YoloDetector("best.onnx");   // Yolo v5���� ������ pt���� ����

            while (video != null)
            {
                if (!isRun)
                    continue;

                var startTime = DateTime.Now;


                if (video.PosFrames != video.FrameCount)
                {
                    video.Read(mat_video);

                    float ratio = 0.0f;
                    Point diff1 = new Point();
                    Point diff2 = new Point();
                    var letter_image = YoloDetector.CreateLetterbox(mat_video, new Size(640, 384), new Scalar(114, 114, 114), out ratio, out diff1, out diff2);
                    var result = detector.objectDetection(mat_video);

                    using (var dispImage = mat_video.Clone())
                    {
                        foreach (var obj in result)
                        {
                            Cv2.Rectangle(dispImage, new Point(obj.Box.Xmin, obj.Box.Ymin), new Point(obj.Box.Xmax, obj.Box.Ymax), new Scalar(0, 0, 255), 2);
                            Cv2.PutText(dispImage, obj.Label, new Point(obj.Box.Xmin, obj.Box.Ymin - 5), HersheyFonts.HersheySimplex, 1, new Scalar(0, 0, 255), 2);
                        }

                        System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(dispImage.ToBytes());

                        // �޸� ���� ���� ����
                        if (videoBox.Image != null)
                        {
                            videoBox.Image.Dispose();
                        }

                        videoBox.Image = new Bitmap(memoryStream);

                    }


                }

            }

        }

        private void pictureCallback(PictureBox usrPictureBox, String filename)
        {
            var detector = new YoloDetector("best.onnx");
            using (var image = Cv2.ImRead(filename))
            {

                float ratio = 0.0f;
                Point diff1 = new Point();
                Point diff2 = new Point();
                var letter_image = YoloDetector.CreateLetterbox(image, new Size(640, 384), new Scalar(114, 114, 114), out ratio, out diff1, out diff2);
                var result = detector.objectDetection(image);


                using (var dispImage = image.Clone())
                {
                    foreach (var obj in result)
                    {
                        Cv2.Rectangle(dispImage, new Point(obj.Box.Xmin, obj.Box.Ymin), new Point(obj.Box.Xmax, obj.Box.Ymax), new Scalar(0, 0, 255), 2);
                        Cv2.PutText(dispImage, obj.Label, new Point(obj.Box.Xmin, obj.Box.Ymin - 5), HersheyFonts.HersheySimplex, 1, new Scalar(0, 0, 255), 2);
                    }


                    System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(dispImage.ToBytes());

                    // �޸� ���� ���� ����
                    if (usrPictureBox.Image != null)
                    {
                        usrPictureBox.Image.Dispose();
                    }

                    usrPictureBox.Image = new Bitmap(memoryStream);

                }

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cameraClosed();
            videoClosed();

            // Process Kill
            System.Diagnostics.Process[] mProcess = System.Diagnostics.Process.GetProcessesByName(Application.ProductName);
            foreach (System.Diagnostics.Process p in mProcess)
                p.Kill();

        }

        private void cameraClosed()
        {

            isCameraOn = false;

            if (thread_camera != null &&
                thread_camera.IsAlive &&
                cameraCapture != null)
            {
                if (cameraCapture.IsOpened())
                {
                    cameraCapture.Release();

                    if (mat_camera != null)
                    {
                        mat_camera.Dispose();
                    }

                    if (destMat_camera != null)
                    {
                        destMat_camera.Dispose();
                    }

                    thread_camera.Interrupt();

                }

            }

        }


        private void videoClosed()
        {

            if (thread_video != null &&
                thread_video.IsAlive &&
                videoCapture != null)
            {
                if (videoCapture.IsOpened())
                {
                    videoCapture.Release();

                    if (mat_video != null)
                    {
                        mat_video.Dispose();
                    }

                    thread_video.Interrupt();

                }

            }

        }

        private void btnCameraOn_Click(object sender, EventArgs e)
        {
            thread_camera = new Thread(new ThreadStart(CameraCallback));
            thread_camera.Start();

            isCameraOn = true;

        }

        private void btnCameraOff_Click(object sender, EventArgs e)
        {
            isCameraOn = false;
            cameraClosed();
        }

        private void ����ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutFrm frm = new AboutFrm();
            frm.ShowDialog();
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}