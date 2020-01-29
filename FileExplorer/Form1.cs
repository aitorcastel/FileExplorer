using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FileExplorer
{
    public partial class Form1 : Form
    {

        List<String> listFiles = new List<string>();
        List<String> listDir = new List<string>();

        public Form1()
        {
            InitializeComponent();


            // rutaTextBox.Text = Directory.GetCurrentDirectory();
            rutaTextBox.Text = "C:\\Users\\aitor\\Desktop\\PruebaC#";

        }

        private void abrirButton_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Url = new Uri(rutaTextBox.Text);

                listFiles.Clear();
                listDir.Clear();

                ficherosList.Items.Clear();
                directorioList.Items.Clear();

                foreach (String item in Directory.GetFiles(rutaTextBox.Text))
                {
                    ficherosList.Items.Add(item);
                }



                foreach (String dir in Directory.GetDirectories(rutaTextBox.Text))
                {
                    directorioList.Items.Add(dir);
                }

            }
            catch (Exception) { }

        }

        private void verFicheroButton_Click(object sender, EventArgs e)
        {
            try 
            {
                contenidoFichero.Text = File.ReadAllText(changeTextBox.Text);
            }
            catch (Exception) { }
        }

        private void rutaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void crearButton_Click_1(object sender, EventArgs e)
        {

            /*
             * https://docs.microsoft.com/es-es/dotnet/api/system.io.directory.createdirectory?view=netframework-4.8
             * https://docs.microsoft.com/es-es/dotnet/api/system.io.file.move?view=netframework-4.8
             *        
             */

            /*
             * Do not use the following reserved names for the name of a file: 
             *      CON, PRN, AUX, NUL, COM1, COM2, COM3, COM4, COM5, COM6, COM7, 
             *      COM8, COM9, LPT1, LPT2, LPT3, LPT4, LPT5, LPT6, LPT7, LPT8, and LPT9.
             * Also avoid these names followed immediately by an extension; for example, NUL.txt is not recommended.
             * 
             */

            try
            {

                String path = rutaTextBox.Text;
                String path2 = changeTextBox.Text;

                if (directorioRadioButton.Checked)
                {
                    if (!Directory.Exists(path2))
                    {
                        DirectoryInfo di = Directory.CreateDirectory(path2);
                        Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));
                    }


                }
                else if (ficheroRadioButton.Checked)
                {

                    if (!File.Exists(path))
                    {
                        using (FileStream fs = File.Create(path2));
                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void changeDirTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void directorioRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            /*
             *  https://docs.microsoft.com/en-us/dotnet/api/system.io.directory.delete?redirectedfrom=MSDN&view=netframework-4.8#System_IO_Directory_Delete_System_String_System_Boolean_
             */
            try
            {
                String path = rutaTextBox.Text;
                String path2 = changeTextBox.Text;

                if (directorioRadioButton.Checked)
                {
                    if (Directory.Exists(path2))
                    {
                        Directory.Delete(path2, true);
                    }


                }
                else if (ficheroRadioButton.Checked)
                {

                    if (File.Exists(path2))
                    {
                        File.Delete(path2);
                    }

                }
            } catch (Exception)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void moverButton_Click(object sender, EventArgs e)
        {
            /* No hay diferencia entre renombrar y mover en C#
             * https://docs.microsoft.com/en-us/dotnet/api/system.io.directory.move?view=netframework-4.8
             */

            try
            {
                String path = changeTextBox.Text;
                String path2 = moveTextBox.Text;

                if (directorioRadioButton.Checked)
                {
                    if (!Directory.Exists(path2))
                    {
                        Directory.Move(path, path2);
                    }


                }
                else if (ficheroRadioButton.Checked)
                {

                    if (!File.Exists(path2))
                    {
                        File.Move(path, path2);
                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void modFicheroButton_Click(object sender, EventArgs e)
        {
            try
            {
                File.WriteAllText(changeTextBox.Text, contenidoFichero.Text);
            } catch (Exception) { }
            
        }
    }
    
}
