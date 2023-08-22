using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItSocks.Model
{
    class CreatePDF
    {
        public string showText()
        {


            return "";
        }



        //I'm stuck at the moment here. So I put this aside for now and take it up with the teachers tomorrow
        public void SaveToPDF()
        {
            string fileText = "Test";

            SaveFileDialog dialog = new SaveFileDialog()
            {
                Filter = "Text Files(*.txt)|*.txt|All(*.*)|*"
            };

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, fileText);
            }

        }
    }
}
