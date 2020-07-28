using EasyTest_App.OOP;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyTest_App.BL
{
    public class Service
    {
        public static List<StudentLog> StudentsList = new List<StudentLog>();
        public static DataTable CheckExamDateTime(DataTable examTable)
        {
            /*
            DateTime nowDate = DateTime.Now.Date;
            //TimeSpan nowTime = DateTime.Now.TimeOfDay;
            List<int> indexList = new List<int>();

            DataTable newExamTable = new DataTable();
            int indexNum = -1;

            foreach(DataRow row in examTable.Rows)
            {
                indexNum++;
                if (!row[5].ToString().Equals(nowDate.ToString()))
                {
                    
                    indexList.Add(indexNum);
                   

                }
            }
            for(int i = 0; i < indexList.Count; i++)
            {
                examTable.Rows[indexList[i]].Delete();
            }
            examTable.AcceptChanges();
            */
            List<int> indexList = new List<int>();
            DateTime nowTime = DateTime.Now;
            TimeSpan MinTimeToStart = TimeSpan.FromMinutes(30);
            indexList.Clear();

            int indexNum = -1;
            foreach (DataRow row in examTable.Rows) //newExamTable
            {
                indexNum++;
                DateTime rowTime =  DateTime.Parse(row[6].ToString());
               if(rowTime - nowTime > MinTimeToStart || nowTime - rowTime > MinTimeToStart) // checks 30 minutes befor and after 
                {
                    indexList.Add(indexNum);     
                }
                
            }
            for (int i = 0; i < indexList.Count; i++)
            {
                examTable.Rows[indexList[i]].Delete();
            }
            examTable.AcceptChanges();



            return examTable;


        }
        


    }
}
