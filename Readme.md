### C sharp - Microsoft ML and DNN, Yolo v5 Sample

##### 1. 프로젝트명: C sharp - Microsoft ML and DNN, Yolo v5 Sample
##### 2. 작성자: 정도윤(Doyoon Jung)
##### 3. 작성일자: 2023-04-05 (Wed) (ver 1.0)
##### 3. 이메일: rabbitsun2 at gmail dot com
##### 4. 비고:
##### -> 리눅스, MS윈도우 두 가지를 혼합하여 작업하였음. (Worked in a mixture of Linux and MS Windows.)
##### 
#####
##### * yolo v5에서 생성한 pt파일 -> onnx로 변환하기(pt file created by yolo v5 -> Convert to onnx)
##### <table style="border:1px solid #e2e2e2"><tr><td>python3 export.py --weights /home/rabbitsun2/yolov5/runs/train/yolov5_coco2/weights/best.pt --include onnx --dynamic</td></tr></table>
##### * C# NuGet 패키지(C# NuGet package)
##### <table style="border:1px solid #e2e2e2">
##### <tr><td style="border-bottom:1px solid #e2e2e2;border-right:1px solid #e2e2e2;">1</td><td style="border-bottom:1px solid #e2e2e2">Microsoft.ML 2.0.1 (2023-02-01 수)</td></tr>
##### <tr><td style="border-bottom:1px solid #e2e2e2;border-right:1px solid #e2e2e2;">2</td><td style="border-bottom:1px solid #e2e2e2">Microsoft.ML.OnnxRuntime 1.14.1 (2023-02-28 화)</td></tr>
##### <tr><td style="border-bottom:1px solid #e2e2e2;border-right:1px solid #e2e2e2;">3</td><td style="border-bottom:1px solid #e2e2e2">OpenCVSharp4 4.7.0.20230115 (2023-01-16 월))</td></tr>
##### </table>
##### 5. 참고자료(Reference)
##### 1. CUDA Toolkit 11.7 Downloads, https://developer.nvidia.com/cuda-downloads?target_os=Linux&target_arch=x86_64&Distribution=Ubuntu&target_version=22.04&target_type=runfile_local, Accessed by 2023-03, Last Modified 2023-03.
##### 2. 효율적인 머신러닝 개발환경은?(디지털투데이), https://www.digitaltoday.co.kr/news/articleView.html?idxno=74630, Accessed by 2023-03, Last Modified 2016-12-13.
##### 3. Complete Pytorch Tensor Tutorial (Initializing Tensors, Math, Indexing, Reshaping), https://www.youtube.com/watch?v=x9JiIFvlUwk&list=PLhhyoLH6IjfxeoooqP9rhU3HJIAVAJ3Vz&index=2&themeRefresh=1, Accessed by 2023-03, Last Modified 2020.
##### 4. Miniconda &mdash; conda   documentation, https://docs.conda.io/en/latest/miniconda.html#linux-installers, Accessed by 2023-03, Last Modified 2023-03.
##### 5. cuda 설치 오류(Nouveau kernel driver), https://velog.io/@hjeun0111/cuda-%EC%84%A4%EC%B9%98-%EC%98%A4%EB%A5%98Nouveau-kernel-driver, Accessed by 2023-03, Last Modified 2022-09-26.
##### 6. Ubuntu 20.04 CUDA 11.2 설치 | SleeP, https://sanglee325.github.io/environment/install-CUDA-11-2/#1-%EC%84%A4%EC%B9%98, Accessed by 2023-03, Last Modified 2021-08-21.
##### 7. [Ubuntu 20.04 LTS]Nvidia드라이버 설치하기, https://pstudio411.tistory.com/entry/Ubuntu-2004-Nvidia%EB%93%9C%EB%9D%BC%EC%9D%B4%EB%B2%84-%EC%84%A4%EC%B9%98%ED%95%98%EA%B8%B0, Accessed by 2023-03, Last Modified 2020-09-11.
##### 8. TIL : nvidia-smi Failed to initialize NVML 에러, https://simonezz.tistory.com/67, Accessed by 2023-03, Last Modified 2016-12-13.
##### 9. Failed to initialize NVML: Driver/library version mismatch 에러 해결, https://light-tree.tistory.com/203?category=1001511, Accessed by 2023-03, Last Modified 2022-11-06.
##### 10. Ubuntu에서 CUDA 완전 삭제 명령어, https://soundprovider.tistory.com/entry/Ubuntu%EC%97%90%EC%84%9C-CUDA-%EC%99%84%EC%A0%84-%EC%82%AD%EC%A0%9C-%EB%AA%85%EB%A0%B9%EC%96%B4, Accessed by 2023-03, Last Modified 2020-06-04.
##### 11. Ubuntu 20.04 CUDA 재설치, https://jeo96.tistory.com/entry/Ubuntu-2004-CUDA-%EC%9E%AC%EC%84%A4%EC%B9%98, Accessed by 2023-03, Last Modified 2022-06-14.
##### 12. Linux x64 (AMD64/EM64T) Display Driver | 525.89.02 | Linux 64-bit | NVIDIA, https://www.nvidia.co.kr/download/driverResults.aspx/199664/kr, Accessed by 2023-03, Last Modified 2023-02-08.
##### 13. virtualbox - &quot;FATAL: Module vboxdrv not found in directory /lib/modules/4.10.0-20-generic&quot; - Ask Ubuntu, https://askubuntu.com/questions/912011/fatal-module-vboxdrv-not-found-in-directory-lib-modules-4-10-0-20-generic, Accessed by 2023-03, Last Modified 2017-08.
##### 14. GeForce 지포스 그래픽 카드 CUDA 지원 여부 확인하는 방법, https://zeliard.tistory.com/entry/how-check-geforce-graphic-card-supports-cuda, Accessed by 2023-03, Last Modified 2022-07-13.
##### 15. *How to install Cuda 11.4 on ubuntu 18.04(or 20.04), https://medium.com/@anarmammadli/how-to-install-cuda-11-4-on-ubuntu-18-04-or-20-04-63f3dee2099, Accessed by 2023-03, Last Modified 2021-07-17.
##### 16. **GitHub - ashutoshIITK/install_cuda_cudnn_ubuntu_20: Tutorial to install NVIDIA Drivers, CUDA 11.4 and cuDNN for deep learning programming on Ubuntu 20.04., https://github.com/ashutoshIITK/install_cuda_cudnn_ubuntu_20, Accessed by 2023-03, Last Modified 2021-07-17.
##### 17. Ubuntu 20.04 CUDA 11.2 설치 후, https://sanglee325.github.io/environment/install-CUDA-11-2/#cudnn-%EC%84%A4%EC%B9%98, Accessed by 2023-03, Last Modified 2021-08-21.
##### 18. 우분투 서버 한글 설정 및 한글폰트 설치, https://findnew.tistory.com/22, Accessed by 2023-03, Last Modified 2017-04-14.
##### 19. YOLO v5 커스텀 학습 튜토리얼, https://www.youtube.com/watch?v=T0DO1C8uYP8, Accessed by 2023-03, Last Modified 2021.
##### 20. [오류] load() missing 1 required positional argument: 'Loade22,10t03, https://kingnamji.tistory.com/57, Accessed by 2023-03, Last Modified 2022-10-03.
##### 21. 일분 노하우 - ubuntu 한국시간으로 변경 및 시간 동기화 설정, https://infrabank.kr/oneminutes/?mod=document&uid=30, Accessed by 2023-03, Last Modified 2021-03-24.
##### 22. C# 기반 배포 가능한 딥러닝 객체 감지 프로그램 개발(feat. YOLO v5) #2, https://blog.hbsmith.io/c-%EA%B8%B0%EB%B0%98-%EB%B0%B0%ED%8F%AC-%EA%B0%80%EB%8A%A5%ED%95%9C-%EB%94%A5%EB%9F%AC%EB%8B%9D-%EA%B0%9D%EC%B2%B4-%EA%B0%90%EC%A7%80-%ED%94%84%EB%A1%9C%EA%B7%B8%EB%9E%A8-%EA%B0%9C%EB%B0%9C-feat-yolo-v5-2-3310b8d81a82, Accessed by 2023-03, Last Modified 2021-06-03.
##### 23. GitHub - singetta/OnnxSample: C# 기반 YOLOv5 Model 사용 샘플 코드, https://github.com/singetta/OnnxSample, Accessed by 2023-03, Last Modified 2022-03-24.
##### 24. onnxruntime  has error in detect.py · Issue #4484 · ultralytics/yolov5 · GitHub, https://github.com/ultralytics/yolov5/issues/4484, Accessed by 2023-03, Last Modified 2021-08-19.
##### 25. C# OpenCV 강좌 : 제 5강 - VIDEO 출력, https://076923.github.io/posts/C-opencv4-5, Accessed by 2023-03, Last Modified 2019-07-07.
##### 26. 아나콘다 가상환경, IPython커널 설정, https://hirandd.tistory.com/77, Accessed by 2023-03, Last Modified 2022-03-16.
##### 27. yolov5 사용법, https://velog.io/@k_chae1/yolov5-%EC%82%AC%EC%9A%A9%EB%B2%95#1-roboflow-dataset-download, Accessed by 2023-03, Last Modified 2022-09-14.
##### 28. Anaconda에서 Scikit-learn(사이킷런) 사용하기, https://d-e-v.tistory.com/10, Accessed by 2023-03, Last Modified 2019-03-12.
##### 29. 뉴욕거리걷기 East 69 Street, 1~5 Avenue in Manhattan, NY, https://www.youtube.com/watch?v=_v0DGhPjTec, Accessed by 2023-03, Last Modified 2019.
##### 30. Install GitLab on Ubuntu 22.04, https://linuxhint.com/install-gitlab-ubuntu-22-04/, Accessed by 2023-03, Last Modified 2022-05.
##### 31. Permission denied to /etc/letsencrypt/live - Help - Let&#39;s Encrypt Community Support, https://community.letsencrypt.org/t/permission-denied-to-etc-letsencrypt-live/72892, Accessed by 2023-03, Last Modified 2018-09.
##### 32. Reset GitLab CE root Password in Linux | Lindevs, https://lindevs.com/reset-gitlab-ce-root-password-in-linux, Accessed by 2023-03, Last Modified 2021-09-09.
##### 33. GitLab 설정 파일 및 명령어, https://abc2080.tistory.com/entry/GitLab-%EC%84%A4%EC%A0%95-%ED%8C%8C%EC%9D%BC-%EB%B0%8F-%EB%AA%85%EB%A0%B9%EC%96%B4, Accessed by 2023-03, Last Modified 2018-06-22.
##### 34. [GitLab] Let's Encrypt를 활용하여 SSL 적용하기, https://www.oofbird.me/39, Accessed by 2023-03, Last Modified 2017-06-19.
##### 35. Insufficient permissions when using certificates · v2fly/fhs-install-v2ray Wiki · GitHub, https://github.com/v2fly/fhs-install-v2ray/wiki/Insufficient-permissions-when-using-certificates, Accessed by 2023-03, Last Modified 2020-08-16.
##### 36. GeForce 지포스 그래픽 카드 CUDA 지원 여부 확인하는 방법, https://zeliard.tistory.com/entry/how-check-geforce-graphic-card-supports-cuda, Accessed by 2023-03, Last Modified 2022-07-13.
##### 37. [오류] load() missing 1 required positional argument: 'Loader', https://kingnamji.tistory.com/57, Accessed by 2023-03, Last Modified 2022-10-03.
##### 38. Ubuntu 18.04 : NFS Server 설치, 구성 방법, 예제, 명령어, https://jjeongil.tistory.com/1620, Accessed by 2023-03, Last Modified 2021-10-10.
##### 39. Ubuntu 22.04 LTS 에서 웹서버(Apache + PHP + MySQL) 구성하기, https://blog.lael.be/post/11072, Accessed by 2023-03, Last Modified 2022-04-25.
##### 40. Remote Desktop Ubuntu – Easy Xrdp Setup, https://hands-on.cloud/remote-desktop-ubuntu-xrdp/, Accessed by 2023-03, Last Modified 2021-05-26.
##### 41. 주피터 서버 구축하기 (2/3) [SSL Certificate로 주피터 서버 보안 강화하기] (Window Server), https://etloveguitar.tistory.com/6, Accessed by 2023-03, Last Modified 2019-01-27.
##### 42. Anaconda에서 Scikit-learn(사이킷런) 사용하기, https://d-e-v.tistory.com/10, Accessed by 2023-03, Last Modified 2019-03-12.
##### 43. Samba를 이용하여 Ubuntu와 Windows간 파일 공유하기 ( 설정 방법 ), https://webnautes.tistory.com/490, Accessed by 2023-03, Last Modified 2021-11-13.
##### 44. Ubuntu 18.04 : NFS Server 설치, 구성 방법, 예제, 명령어, https://jjeongil.tistory.com/1620, Accessed by 2023-03, Last Modified 2021-10-10.
##### 45. GitHub - shimat/opencvsharp: OpenCV wrapper for .NET, https://github.com/shimat/opencvsharp, Accessed by 2023-03, Last Modified 2023.