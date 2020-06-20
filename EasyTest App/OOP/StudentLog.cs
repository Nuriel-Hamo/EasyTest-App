using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyTest_App.OOP
{ 

    public class StudentLog
    {
       
        private int studentID;
        private string firstName;
        private string lastName;
        private string noteookNum;
        private int tableNum;

        public StudentLog(int student_id, string first_name, string last_name, string notebook_num, int table_num)
        {
            studentID = student_id;
            firstName = first_name;
            lastName = last_name;
            noteookNum = notebook_num;
            tableNum = table_num;

        }
        public int StudentID { get { return this.studentID; } set { this.studentID = value; } }
        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }
        public string NoteookNum { get { return this.noteookNum; } set { this.noteookNum = value; } }
        public int TableNum { get { return this.tableNum; } set { this.tableNum = value; } }

    }
}
