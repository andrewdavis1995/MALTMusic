using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MALT_Music.DataObjects
{
    class Validation
    {
        private String errorMessage;
        private bool validity;

        public Validation(String error, bool valid) {
            this.errorMessage = error;
            this.validity = valid;
        }

        public String getError() { return this.errorMessage; }
        public bool getValidity() { return this.validity; }

    }
}
