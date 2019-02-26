using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    enum Season { Spring=12, Fall=0, Summer=10, Winter=-10 }

    enum Session { FA, SP }
    enum DegreeProgram { BCS, BSE, BBA }

    struct RegNo
    {
        private Session session;
        private DegreeProgram program;
        private int year;
        private string rollno;
        public RegNo(Session session, int year, DegreeProgram program, string rollno )
        {
            this.session = session;
            this.year = year;
            this.program = program;
            this.rollno = rollno;
        }
        public Session getSession()
        {
            return this.session;
        }
        public override string ToString()
        {
            return this.session.ToString() + (this.year%2000) + "-" + this.program + "-" + this.rollno;
        }
    }

}
