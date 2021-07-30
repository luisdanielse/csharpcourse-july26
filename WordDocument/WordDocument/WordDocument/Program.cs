using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MyTasks = System.Threading.Tasks;

// Namespace for the word document (Application interface)
using Microsoft.Office.Interop.Word;

namespace WordDocument
{
    class Program
    {
        static async MyTasks.Task Main(string[] args)
        {
            Console.WriteLine("Press any key to start creating the file");
            Console.ReadKey();

            try
            {
                Console.WriteLine("Start creating the file");
                string fileName = await DocumentGenerator.GenerateFile();
                Console.WriteLine("File created");
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occurred: {0}", ex.Message);
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }

    /* This class will contain all the methods required
     * to put content into the word document */
    public class WordWrapper
    {
        dynamic _word = null;

        public WordWrapper()
        {
            this._word = new Application { Visible = false };
        }

        public void CreateBlankDocument()
        {
            var doc = this._word.Documents.Add();
            doc.Activate();
        }

        public void AppendHeading(string text)
        {
            var currentLocation = this.GetEndOfDocument();

            currentLocation.InsertAfter(text);
            currentLocation.set_Style(WdBuiltinStyle.wdStyleHeading1);
            currentLocation.InsertParagraphAfter();
        }

        public void InsertCarriageReturn()
        {
            var currentLocation = this.GetEndOfDocument();
            currentLocation.InsertBreak(WdBreakType.wdLineBreak);
        }

        public void AppendText(string text, bool bold,bool underline)
        {
            var currentLocation = this.GetEndOfDocument();

            currentLocation.Bold = bold ? 1 : 0;
            currentLocation.Underline = underline ? WdUnderline.wdUnderlineSingle : WdUnderline.wdUnderlineNone;
            currentLocation.InsertAfter(text);            


        }

        public void SaveAs(string filePath)
        {
            var currentDocument = this._word.ActiveDocument;

            currentDocument.SaveAs(filePath);
            currentDocument.Close();
        }


        private Range GetEndOfDocument()
        {
            return this._word.ActiveDocument.Range(this._word.ActiveDocument.Content.End - 1);
        } 
    }
    
    /* Class that manages the creation and the content of the document */
    public class DocumentGenerator
    {

        public static async MyTasks.Task<string> GenerateFile()
        {
            var task = new MyTasks.Task<string>(() =>
            {
                string fileName = @"E:\visual-studiop\C#July2021\WordDocument\WordDocument\WordDocument\fileCreated.docx";
                WordWrapper wrapper = new WordWrapper();
                wrapper.CreateBlankDocument();
                wrapper.AppendHeading("This is a header of the document");
                wrapper.InsertCarriageReturn();
                wrapper.InsertCarriageReturn();
                wrapper.InsertCarriageReturn();

                wrapper.AppendText("This text will be bold and underlined", true, true);
                wrapper.InsertCarriageReturn();
                wrapper.AppendText("This row  1 is normal (not bold and neither underlined)",false, false);
                wrapper.InsertCarriageReturn();
                wrapper.AppendText("This row  2 is normal (not bold and neither underlined)", false, false);
                wrapper.InsertCarriageReturn();
                wrapper.AppendText("This row  3 is normal (not bold and neither underlined)", false, false);
                wrapper.InsertCarriageReturn();
                wrapper.InsertCarriageReturn();
                wrapper.InsertCarriageReturn();
                wrapper.InsertCarriageReturn();
                wrapper.AppendHeading("This is another header of the document");
                wrapper.SaveAs(fileName);
                return fileName;
            });
            task.Start();
            string myFile = await task;

            return myFile;
        }

    }

}
