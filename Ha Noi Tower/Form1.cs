using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ha_Noi_Tower
{
    public partial class THN : Form
    {
        TimeSpan time;
        PictureBox[] disks;
        int MoveCount;
        private int bestMoveCount = int.MaxValue; // Khởi tạo với giá trị tối đa của kiểu int
        MyStack disksA, disksB, disksC, firstClickedDisks, secondClickedDisks;
        const int FirstY = 315, DiskHeight = 20, DISTXFORMRODTODISK = 26;


        public THN()
        {
            InitializeComponent();
            disks = new PictureBox[] { pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8 };
            picRodA.Tag = disksA = new MyStack();
            picRodB.Tag = disksB = new MyStack();
            picRodC.Tag = disksC = new MyStack();
        }
        private void THN_Load(object sender, EventArgs e)
        {

        }


        private void lblMoveCount_Click(object sender, EventArgs e)
        {

        }
        private void pic1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
        private void nudLevel_ValueChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click_2(object sender, EventArgs e)
        {

        }
        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnShowRule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-Bạn chỉ được phép di chuyển một đĩa một lần và chỉ được phép di chuyển đĩa ở đầu của một cột" +
                ".\r\n-Bạn không thể đặt một đĩa lớn hơn lên trên một đĩa nhỏ.\r\n-Mục tiêu là di chuyển tất cả các đĩa từ " +
                "cột xuất phát sang cột đích một cách ít bước nhất."
                            , "Luật chơi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void tmrCountTime_Tick(object sender, EventArgs e)
        {
            time = time.Add(new TimeSpan(0, 0, 1));
            lblTime.Text = string.Format("Thời gian: {0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
        }
        private void btnGiveup_Click(object sender, EventArgs e)
        {
            tmrCountTime.Stop();
            nudLevel.Enabled = true;
            btnGiveup.Enabled = false;
            btnPlay.Text = "Chơi";
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            //reset 
            tmrCountTime.Stop();
            foreach (PictureBox disk in disks)
                disk.Visible = false;
            time = new TimeSpan(0);
            MoveCount = 0;
            lblTime.Text = "Thời gian: 00:00:00";
            lblMoveCount.Text = "Số lần di chuyển: 0 lần";
            disksA.Clear(); disksB.Clear(); disksC.Clear();
            picRodA.BorderStyle = picRodB.BorderStyle = picRodC.BorderStyle = BorderStyle.None;
            firstClickedDisks = secondClickedDisks = null;
            // bắt đầu một game mới 
            nudLevel.Enabled = false; // ko cho sửa số đĩa lúc đang chơi 
            btnGiveup.Enabled = true;
            btnPlay.Text = "Chơi lại";
            int x = picRodA.Location.X + DISTXFORMRODTODISK, y = FirstY;
            for (int i = (int)nudLevel.Value - 1; i >= 0; i--, y -= DiskHeight)//thể hiện số đĩa lúc đầu 
            {
                disks[i].Location = new Point(x, y);
                disks[i].Visible = true;
                disksA.Push(disks[i]);
            }    // tất cả là cột A 
            tmrCountTime.Start();
            int numberOfDisks = (int)nudLevel.Value;
            int moveCount = 0;
            string solution = SolveTowerOfHanoi(numberOfDisks, 'A', 'C', 'B', ref moveCount);
            lblMoveCountDisplay.Text = moveCount.ToString();
        }
        private void picRod_Click(object sender, EventArgs e)
        {
            if (nudLevel.Enabled) return; // đang ko chơi nên đc sửa, tức là ko chọn cọc
            PictureBox clickedRod = (PictureBox)sender; //bật đường viền khi nhấn vào cọc 
            MyStack diskofClickedRod = (MyStack)clickedRod.Tag;
            if (firstClickedDisks == null)
            {
                if (diskofClickedRod.Count == 0) { return; } // nếu cọc ko có đĩa thì return 
                firstClickedDisks = diskofClickedRod;
                clickedRod.BorderStyle = BorderStyle.FixedSingle;
            }
            else if (secondClickedDisks == null)
            {
                if (diskofClickedRod == firstClickedDisks) // nhấn vào một cột thì bỏ chọn
                {
                    firstClickedDisks = null;
                    clickedRod.BorderStyle = BorderStyle.None;
                    return;
                }
                secondClickedDisks = diskofClickedRod;
                ProcessMovingDisk(clickedRod);
            }
        }
        private void lblBestMoveCount_Click(object sender, EventArgs e)
        {

        }
        private void btnSolve_Click(object sender, EventArgs e)
        {
            // Lấy số đĩa mà người dùng đã chọn
            int numberOfDisks = (int)nudLevel.Value;

            // Gọi hàm giải quyết bài toán đệ quy giải tháp Hà Nội với số đĩa đã chọn
            int moveCount = 0;
            string solution = SolveTowerOfHanoi(numberOfDisks, 'A', 'C', 'B', ref moveCount);
            // Hiển thị kết quả trong một cửa sổ thông báo
            MessageBox.Show(solution, "Lời giải", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Gán số lần di chuyển vào Label để hiển thị trên giao diện
            lblMoveCountDisplay.Text = moveCount.ToString();
        }
        // Hàm giải quyết bài toán đệ quy giải tháp Hà Nội

        private string SolveTowerOfHanoi(int numDisks, char fromRod, char toRod, char auxRod, ref int moveCount)
        {
            if (numDisks == 1)
            {
                moveCount++;
                return $"{moveCount}. Di chuyển đĩa 1 từ cột {fromRod} đến cột {toRod}\n  ";
            }

            string moveSteps = "";

            moveSteps += SolveTowerOfHanoi(numDisks - 1, fromRod, auxRod, toRod, ref moveCount);

            moveCount++;
            moveSteps += $"{moveCount}. Di chuyển đĩa {numDisks} từ cột {fromRod} đến cột {toRod}\n";

            moveSteps += SolveTowerOfHanoi(numDisks - 1, auxRod, toRod, fromRod, ref moveCount);

            return moveSteps;
        }

        private void ProcessMovingDisk(PictureBox clickedRod)
        {
            if (secondClickedDisks.Count == 0)
            {
                MoveDisk(new Point(clickedRod.Location.X + DISTXFORMRODTODISK, FirstY));
            }
            else
            {
                PictureBox firstTopDisk = firstClickedDisks.Peek();
                PictureBox secondTopDisk = secondClickedDisks.Peek();
                if (int.Parse(firstTopDisk.Tag.ToString()) < int.Parse(secondTopDisk.Tag.ToString()))
                    MoveDisk(new Point(secondTopDisk.Location.X, secondTopDisk.Location.Y - DiskHeight)); // dời sang chung một cọc nên chung X
                else
                    secondClickedDisks = null; // ko thỏa điều kiện nên bỏ chọn 
            }
        }
        private void MoveDisk(Point point)
        {
            PictureBox firstTopDisk = firstClickedDisks.Pop();
            firstTopDisk.Location = point;
            secondClickedDisks.Push(firstTopDisk);
            MoveCount++;
            lblMoveCount.Text = string.Format("Số lần di chuyển: {0} lần ", MoveCount);
            firstClickedDisks = secondClickedDisks = null;
            picRodA.BorderStyle = picRodB.BorderStyle = picRodC.BorderStyle = BorderStyle.None; // bỏ border khi di chuyển xong một đĩa 
            if (disksC.Count == nudLevel.Value)
            {
                // Kiểm tra xem số lần di chuyển trong trò chơi này có thấp hơn kỷ lục không
                if (MoveCount < bestMoveCount)
                {
                    bestMoveCount = MoveCount;
                    MessageBox.Show($"Chúc mừng! Bạn đã phá kỷ lục số lần di chuyển thấp nhất với {bestMoveCount} lần.", "Kỷ lục mới");
                }

                // Hiển thị kỷ lục số lần di chuyển thấp nhất trên giao diện
                lblBestMoveCount.Text = $"Kỷ lục: {bestMoveCount} lần";

                // Đặt lại số lần di chuyển và chuẩn bị cho trò chơi tiếp theo
                MoveCount = 0;
                lblMoveCount.Text = "Số lần di chuyển: 0 lần";
                btnGiveup.PerformClick(); // Kết thúc trò chơi
            }
            if (disksC.Count   == nudLevel.Value)
            {
                btnGiveup.PerformClick(); // mượn tác dụng của button 
                MessageBox.Show("Bạn đã hoàn thành trò chơi", "Chúc mừng");
            }
        }
        private void picDisk_Click(object sender, EventArgs e)
        {
            PictureBox clickedDisk = (PictureBox)sender;
            if (disksA.Contains(clickedDisk))
            {
                picRod_Click(picRodA, new EventArgs());
            }
            else if (disksB.Contains(clickedDisk))
            {
                picRod_Click(picRodB, new EventArgs());
            }
            else
            {
                picRod_Click(picRodC, new EventArgs());
            }
        }
        private void AddStack()
        {
            MyStack diskA = new MyStack();
            MyStack diskB = new MyStack();
            MyStack diskC = new MyStack();
            MyStack firstClickedDisks = new MyStack();
            MyStack secondClickedDisks = new MyStack();
        }

    }
}
