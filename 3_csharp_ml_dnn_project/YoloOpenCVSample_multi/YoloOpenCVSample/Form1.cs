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
        bool isGarbage_Run, isPCB_Run;
        bool isZoomUp;

        Thread thread_camera, thread_video, thread_pcb_video;
        Mat mat_camera;
        Mat destMat_camera;
        Mat mat_video, mat_pcb_video;
        VideoCapture cameraCapture;
        VideoCapture videoCapture;
        VideoCapture videoPcbCapture;

        public string camera_option_best_name { get; set; }
        public string picture_option_best_name { get; set; }
        PictureBox camera_current_picture_box { get; set; }

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            isGarbage_Run = false;
            isPCB_Run = false;

            // PictureBox 사용(Garbage)
            picture_option_best_name = "best_garbage.onnx";
            pictureCallback(this.pictureBox_Garbage_1, "garbage_test1.jpg");
            pictureCallback(this.pictureBox_Garbage_2, "garbage_test2.jpg");
            pictureCallback(this.pictureBox_Garbage_3, "garbage_test3.jpg");
            pictureCallback(this.pictureBox_Garbage_4, "garbage_test4.jpg");
            pictureCallback(this.pictureBox_Garbage_5, "garbage_test5.jpg");
            pictureCallback(this.pictureBox_Garbage_6, "garbage_test6.jpg");
            pictureCallback(this.pictureBox_Garbage_7, "garbage_test7.jpg");


            // PictureBox 사용(PCB)
            picture_option_best_name = "best_pcb.onnx";
            pictureCallback(this.pictureBox_Pcb_1, "pcb_test1.jpg");
            pictureCallback(this.pictureBox_Pcb_2, "pcb_test2.jpg");
            pictureCallback(this.pictureBox_Pcb_3, "pcb_test3.jpg");
            pictureCallback(this.pictureBox_Pcb_4, "pcb_test4.jpg");
            pictureCallback(this.pictureBox_Pcb_5, "pcb_test5.jpg");
            pictureCallback(this.pictureBox_Pcb_6, "pcb_test6.jpg");
            pictureCallback(this.pictureBox_Pcb_7, "pcb_test7.jpg");

        }


        private void CameraCallback()
        {
            mat_camera = new Mat();
            cameraCapture = new VideoCapture(0);
            cameraCapture.Set(VideoCaptureProperties.FrameWidth, 640);
            cameraCapture.Set(VideoCaptureProperties.FrameHeight, 480);

            if (!cameraCapture.IsOpened())
            {
                MessageBox.Show("카메라를 열지 못했습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Yolo Detector
            var detector = new YoloDetector(camera_option_best_name);   // Yolo v5에서 추출한 pt파일 적용

            while (isCameraOn)
            {
                try
                {
                    cameraCapture.Read(mat_camera);

                    // n차원 행렬이 비어있을 때
                    if (mat_camera.Empty())
                        break;

                    destMat_camera = mat_camera;

                    // Gaussian 필터 적용
                    Cv2.GaussianBlur(mat_camera, destMat_camera, new OpenCvSharp.Size(), (double)1);

                    // 언샤프 마스크 필터 적용
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

                        // 메모리 누수 버그 방지
                        if (camera_current_picture_box.Image != null)
                        {
                            camera_current_picture_box.Image.Dispose();
                        }

                        camera_current_picture_box.Image = new Bitmap(memoryStream);

                    }

                }
                catch (Exception ex)
                {

                }

            }

            Cv2.DestroyAllWindows();
        }


        private void VideoCallback_garbage_sample()
        {

            VideoCapture video = new VideoCapture(@"D:\\sample.avi");
            mat_video = new Mat();

            // Yolo Detector
            var detector = new YoloDetector("best_garbage.onnx");   // Yolo v5에서 추출한 pt파일 적용

            while (video != null)
            {
                if (!isGarbage_Run)
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

                        try
                        {

                            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(dispImage.ToBytes());

                            // 메모리 누수 버그 방지
                            if (videoGarbage_Box.Image != null)
                            {
                                videoGarbage_Box.Image.Dispose();
                            }

                            videoGarbage_Box.Image = new Bitmap(memoryStream);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("비정상적인 접근입니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }

                    }

                }

            }

        }


        private void VideoCallback_pcb_sample()
        {

            VideoCapture video = new VideoCapture(@"D:\\sample2.avi");
            mat_pcb_video = new Mat();

            // Yolo Detector
            var detector = new YoloDetector("best_pcb.onnx");   // Yolo v5에서 추출한 pt파일 적용

            while (video != null)
            {
                if (!isPCB_Run)
                    continue;

                var startTime = DateTime.Now;


                if (video.PosFrames != video.FrameCount)
                {
                    video.Read(mat_pcb_video);

                    float ratio = 0.0f;
                    Point diff1 = new Point();
                    Point diff2 = new Point();
                    var letter_image = YoloDetector.CreateLetterbox(mat_pcb_video, new Size(800, 704), new Scalar(114, 114, 114), out ratio, out diff1, out diff2);
                    var result = detector.objectDetection(mat_pcb_video);

                    using (var dispImage = mat_pcb_video.Clone())
                    {
                        foreach (var obj in result)
                        {
                            Cv2.Rectangle(dispImage, new Point(obj.Box.Xmin, obj.Box.Ymin), new Point(obj.Box.Xmax, obj.Box.Ymax), new Scalar(0, 0, 255), 2);
                            Cv2.PutText(dispImage, obj.Label, new Point(obj.Box.Xmin, obj.Box.Ymin - 5), HersheyFonts.HersheySimplex, 1, new Scalar(0, 0, 255), 2);
                        }

                        try
                        {
                            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream(dispImage.ToBytes());

                            // 메모리 누수 버그 방지
                            if (videoPcb_Box.Image != null)
                            {
                                videoPcb_Box.Image.Dispose();
                            }

                            videoPcb_Box.Image = new Bitmap(memoryStream);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("비정상적인 접근입니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }


                    }

                }

            }

        }

        private void pictureCallback(PictureBox usrPictureBox, String filename)
        {
            var detector = new YoloDetector(picture_option_best_name);
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

                    // 메모리 누수 버그 방지
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
            videoClosed_garbage();
            videoClosed_pcb();

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


        private void videoClosed_garbage()
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


        private void videoClosed_pcb()
        {

            if (thread_pcb_video != null &&
                thread_pcb_video.IsAlive &&
                videoPcbCapture != null)
            {
                if (videoPcbCapture.IsOpened())
                {
                    videoPcbCapture.Release();

                    if (mat_pcb_video != null)
                    {
                        mat_pcb_video.Dispose();
                    }

                    thread_pcb_video.Interrupt();

                }

            }

        }


        private void 정보ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutFrm frm = new AboutFrm();
            frm.ShowDialog();
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnGarbage_play_Click(object sender, EventArgs e)
        {

            isGarbage_Run = true;

            thread_pcb_video = new Thread(new ThreadStart(VideoCallback_garbage_sample));
            thread_pcb_video.Start();
        }

        private void btnGarbage_Stop_Click(object sender, EventArgs e)
        {

            isGarbage_Run = false;
            videoClosed_garbage();
        }

        private void btnCamera_Garbage_On_Click(object sender, EventArgs e)
        {
            camera_option_best_name = "best_garbage.onnx";
            camera_current_picture_box = this.camera_Garbage_Box;

            isCameraOn = true;
            thread_camera = new Thread(new ThreadStart(CameraCallback));
            thread_camera.Start();

        }

        private void btnCamera_Garbage_Off_Click(object sender, EventArgs e)
        {
            isCameraOn = false;
            camera_current_picture_box = this.camera_Garbage_Box;
            cameraClosed();
        }

        private void btnPCB_play_Click(object sender, EventArgs e)
        {
            isPCB_Run = true;

            thread_pcb_video = new Thread(new ThreadStart(VideoCallback_pcb_sample));
            thread_pcb_video.Start();
        }

        private void btnPCB_stop_Click(object sender, EventArgs e)
        {
            isPCB_Run = false;
            videoClosed_pcb();

        }

        private void btnPCB_camera_on_Click(object sender, EventArgs e)
        {
            camera_option_best_name = "best_pcb.onnx";
            camera_current_picture_box = this.camera_Pcb_Box;

            isCameraOn = true;
            thread_camera = new Thread(new ThreadStart(CameraCallback));
            thread_camera.Start();

        }

        private void btnPCB_camera_off_Click(object sender, EventArgs e)
        {
            isCameraOn = false;
            camera_current_picture_box = this.camera_Pcb_Box;
            cameraClosed();
        }

    }

}