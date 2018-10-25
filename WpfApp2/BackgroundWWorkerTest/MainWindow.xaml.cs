using System;
using System.ComponentModel;
using System.Windows;
using System.Threading;
using System.Windows.Threading;

namespace BackgroundWWorkerTest
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private BackgroundWorker myThread;
        int sum = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            //백그라운드 워커 초기화
            //작업의 진행율이 바뀔때 ProgressChanged 이벤트 발생여부
            //작업취소 가능여부 true로 설정
            myThread = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            //백그라운드에서 실행될 콜백 이벤트 생성
            //For the performing operation in the background.
            //해야할 작업을 실행할 메소드 정의
            myThread.DoWork += myThread_DoWork;
            //UI쪽에 진행사항을 보여주기 위해
            //WorkerReportsProgress 속성값이 true 일때만 이벤트 발생
            myThread.ProgressChanged += myThread_ProgressChanged;
            //작업이 완료되었을 때 실행할 콜백메소드 정의
            myThread.RunWorkerCompleted += myThread_RunWorkerCompleted;
            MessageBox.Show("Worker 초기화");
        }
        private void myThread_DoWork(object sender, DoWorkEventArgs e)
        {
            int count = (int)e.Argument;
            for (int i = 1; i <= count; i++)
            {
                if (myThread.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    Thread.Sleep(100);
                    this.Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                    (ThreadStart)delegate ()
                    {
                        if (i % 2 == 0)
                        {
                            sum += i;
                            e.Result = sum;
                            lstNumber.Items.Add(i);
                        }
                    }
                    );

                    myThread.ReportProgress(i);

                }
            }
        }
        private void myThread_ProgressChanged(object sender,ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }
        //작업완료
        private void myThread_RunWorkerCompleted(object sender,RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) MessageBox.Show("작업 취소...");
            else if (e.Error != null) MessageBox.Show("에러발생..." +
           e.Error);
            else
            {
                tblkSum.Text = ((int)e.Result).ToString();
                MessageBox.Show("작업 완료!!");
            }
        }

        private void btnStart_Click_1(object sender, RoutedEventArgs e)
        {
            int num;
            if (!int.TryParse(txtNumber.Text, out num))
            {
                MessageBox.Show("숫자를 입력하세요.!");
                return;
            }
            progressBar.Maximum = num;
            lstNumber.Items.Clear();
            myThread.RunWorkerAsync(num);
        }

        private void btnCancel_Click_1(object sender, RoutedEventArgs e)
        {
            myThread.CancelAsync();
        }
    }
}
   
