using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            drawing = false; //Переменная, ответственная за рисование
            currentPen = new Pen(Color.Black); //Инициализация пера с черным цветом
            currentPen.Width = tbslider.Value; //Инициализация толщины пера
            History = new List<Image>(); //Инициализация списка для истории
        }

        //==================================================================================================================
        //Forms
        //Form2-Informations-Developns-And-programm
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 AddRec = new Form2();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }
        private void PaletteCokorToolStripButton_Click(object sender, EventArgs e)
        {
            Form3 colorDialog = new Form3(currentPen.Color);
            colorDialog.ColorSelected += OnColorSelected;
            colorDialog.ShowDialog();

        }
        private void OnColorSelected(Color color)
        {
            currentPen.Color = color;
        }
        //==================================================================================================================
        //menu-Save-open-close
        //Save-File
        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4; //По умолчанию будет выбрано последнее расширение *.png
            SaveDlg.ShowDialog();
            if (SaveDlg.FileName != "") //Если введено не пустое имя
            {
                System.IO.FileStream fs = (System.IO.FileStream)SaveDlg.OpenFile();
                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.pbDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.pbDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.pbDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        this.pbDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
            if (pbDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка? ", "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: SaveToolStripButton_Click(sender, e); break;
                    case DialogResult.Cancel: return;
                }
            }
        }
        //Save-File-menu
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            SaveDlg.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            SaveDlg.Title = "Save an Image File";
            SaveDlg.FilterIndex = 4; //По умолчанию будет выбрано последнее расширение *.png
            SaveDlg.ShowDialog();
            if (SaveDlg.FileName != "") //Если введено не пустое имя
            {
                System.IO.FileStream fs = (System.IO.FileStream)SaveDlg.OpenFile();
                switch (SaveDlg.FilterIndex)
                {
                    case 1:
                        this.pbDrawingSurface.Image.Save(fs, ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.pbDrawingSurface.Image.Save(fs, ImageFormat.Bmp);
                        break;
                    case 3:
                        this.pbDrawingSurface.Image.Save(fs, ImageFormat.Gif);
                        break;
                    case 4:
                        this.pbDrawingSurface.Image.Save(fs, ImageFormat.Png);
                        break;
                }
                fs.Close();
            }
            /*
            Если вдруг пользователь захотел создать еще один новый файл, при условии,
            что уже было что - то нарисовано в PictureBox, можно будет ему предложить
            сохранить текущее изображение, чтобы оно не потерялось*/
            if (pbDrawingSurface.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка? ", "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: SaveToolStripButton_Click(sender, e); break; // вызываем окно сохранения
                    case DialogResult.Cancel: return;
                }
            }
        }
        //Open-File
        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image | *.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1; //По умолчанию будет выбрано первое расширение *.jpg И, когда пользователь укажет нужный путь к картинке, ее нужно будет загрузить в PictureBox:
            if (OP.ShowDialog() != DialogResult.Cancel)
            {
                pbDrawingSurface.Load(OP.FileName);
                pbDrawingSurface.AutoSize = true;
            }
            History.Clear();
            historyCounter = 0;
            History.Add(new Bitmap(pbDrawingSurface.Image));
        }
        //Open-File-menu
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image | *.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1; //По умолчанию будет выбрано первое расширение *.jpg И, когда пользователь укажет нужный путь к картинке, ее нужно будет загрузить в PictureBox:
            if (OP.ShowDialog() != DialogResult.Cancel)
            {
                pbDrawingSurface.Load(OP.FileName);
                pbDrawingSurface.AutoSize = true;
            }
            History.Clear();
            historyCounter = 0;
            History.Add(new Bitmap(pbDrawingSurface.Image));
        }
        //Exit-programm
        private void ExitToolStripButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Exit-programm-menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //=========================================================================================================================================================================

        //Глобальные переменные
        bool drawing;
        int historyCounter; //Счетчик истории
        GraphicsPath currentPath;
        Point oldLocation;
        public Pen currentPen;
        Color historyColor; //Сохранение текущего цвета перед использованием ластика
        List<Image> History; //Список для истории


        //New-picturesBox
        private void NewFileToolStripButton_Click(object sender, EventArgs e)
        {
            History.Clear();
            historyCounter = 0;
            Bitmap pic = new Bitmap(1100, 470);
            pbDrawingSurface.Image = pic;
            History.Add(new Bitmap(pbDrawingSurface.Image));
        }
        //New-menu-picturesBox
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History.Clear();
            historyCounter = 0;
            Bitmap pic = new Bitmap(1100, 470);
            pbDrawingSurface.Image = pic;
            History.Add(new Bitmap(pbDrawingSurface.Image));
        }
        //Чтобы пользователь по ошибке не начал рисовать в неинициализированной области PictureBox
        private void pbDrawingSurface_MouseDown(object sender, MouseEventArgs e)
        {
            if (pbDrawingSurface.Image == null)
            {
                MessageBox.Show("Сначала создайте новый файл!");
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
            }
            if (e.Button == MouseButtons.Right)
            {
                historyColor = currentPen.Color; // сохраняем текущий цвет пера
                currentPen.Color = Color.White; // меняем цвет пера на белый
            }
        }
        private void pbDrawingSurface_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false; // Переменная "drawing" устанавливается в значение false, что означает, что пользователь перестал рисовать.

            History.RemoveRange(historyCounter + 1, History.Count - historyCounter - 1); //з истории удаляются все элементы, начиная с позиции historyCounter + 1 (если такие есть), чтобы не сохранять лишние состояния холста.
            History.Add(new Bitmap(pbDrawingSurface.Image));//В историю добавляется новое состояние холста в виде объекта Bitmap.

            if (historyCounter + 1 < 10) //Если количество элементов в истории меньше 10, то увеличивается значение переменной historyCounter на 1. Если количество элементов равно 10, то удаляется первый элемент истории.
            {
                historyCounter++;
                if (History.Count - 1 == 10)
                {
                    History.RemoveAt(0);
                }
            }
            try // Если текущий путь (линия, которую пользователь рисует) существует, он удаляется.
            {
                currentPath.Dispose();
            }
            catch { };
            if (e.Button == MouseButtons.Right) //Если пользователь нажал правую кнопку мыши, цвет текущего пера меняется на цвет из истории (historyColor).
            {
                currentPen.Color = historyColor;
            }
        }
        private void pbDrawingSurface_MouseMove(object sender, MouseEventArgs e) //Этот код отвечает за обработку события перемещения мыши на холсте (pbDrawingSurface_MouseMove). 
        {
            lblCoordinates.Text = "x = "+e.X.ToString() + "; y = " + e.Y.ToString();//Сначала в метку lblCoordinates выводятся координаты текущего положения мыши. 
            if (drawing)
            {
                Graphics g = Graphics.FromImage(pbDrawingSurface.Image); //Если пользователь рисует (drawing=true), то создается объект Graphics для изображения на холсте (pbDrawingSurface.Image), добавляется новая линия к текущему пути (currentPath) от предыдущей точки (oldLocation) до текущей (e.Location), рисуется текущий путь (currentPath) с помощью текущего пера (currentPen) и устанавливается новая точка oldLocation в текущее положение мыши. 
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                pbDrawingSurface.Invalidate();//После этого объект Graphics освобождается и холст перерисовывается (pbDrawingSurface.Invalidate()).
            }
        }

        //Толщина 
        private void tbslider_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = tbslider.Value;
        }

        //-->
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (History.Count != 0 && historyCounter != 0)
            {
                pbDrawingSurface.Image = new Bitmap(History[--historyCounter]);
            }
            else MessageBox.Show("История пуста");
        }
        //<--
        private void RenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyCounter < History.Count - 1)
            {
                pbDrawingSurface.Image = new Bitmap(History[++historyCounter]);
            }
            else MessageBox.Show("История пуста");
        }

        //Стили Pen
        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {   currentPen.DashStyle = DashStyle.Solid;
            solidToolStripMenuItem.Checked = true;
            dotToolStripMenuItem.Checked = false;
            dashToolStripMenuItem.Checked = false;
        }
        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {   currentPen.DashStyle = DashStyle.Dot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = true;
            dashToolStripMenuItem.Checked = false;
        }

        private void dashToolStripMenuItem_Click(object sender, EventArgs e)
        {   currentPen.DashStyle = DashStyle.DashDotDot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = false;
            dashToolStripMenuItem.Checked = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {}
        private void pbDrawingSurface_Click(object sender, EventArgs e)
        {}

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void penToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void styleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblCoordinates_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
