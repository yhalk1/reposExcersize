using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
    public abstract class Status
    {
        public abstract string GetStatusDescription();
    }

    public class Default : Status
    {
        public override string GetStatusDescription() => "I have never been set";
    }

    public class Active : Status
    {
        public override string GetStatusDescription() => "I am active";
    }

    public class New : Status
    {
        public override string GetStatusDescription() => "I am new!";
    }

    public class Deactivated : Status
    {
        public override string GetStatusDescription() => "I have been deactivated"; ///lambda expresion
    }

    public class Katana
    {
        private readonly Status status;

        public Katana()
        {
            status = new Default();
        }

        public Katana(Status status)
        {
            this.status = status;
        }

        //public string GetStatusDescription() => status.GetStatusDescription();

        public string GetStatusDescription()
        {
            return status.GetStatusDescription();
        }
    }
}
