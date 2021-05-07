using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Office.Interop.Word;
using StudTable.Properties;

namespace StudTable
{
     class WordTemplate
    {
        
        private FileInfo _fileInfo;

        public string docName;
        
       
        public WordTemplate(string fileName, string name)
        {
            
            
            
            if (File.Exists(fileName))
            {
            
                _fileInfo = new FileInfo(fileName);

                docName = name;
                 
            }
            else
            {
                throw new ArgumentException("Fle not found");
            }
            
            
        }
        
        

        internal bool Process(Dictionary<string, string> items)
        {
            
            
            
            Application app = null;
            try
            {
                app = new Application();
                Object file = _fileInfo.FullName;
                Object missing = Type.Missing;
                
                app.Documents.Open(file);

                foreach (var item in items)
                {
                    Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = WdFindWrap.wdFindContinue;
                    Object replace = WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replace);
                }

              
                Object newFileName = Path.Combine(Settings.Default.FolderPath , "Заявление №"+  Settings.Default.Id + " " + docName   );
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();
                

                            

               
                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                if (app != null)
                {
                    app.Quit();
                }
            }
            return false;
        }
                    

    }
}