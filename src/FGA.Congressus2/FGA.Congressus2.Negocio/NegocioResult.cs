using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FGA.Congressus2.Negocio
{
    public class NegocioResult<T> where T: class
    {
        public bool Succeeded { get; set; } = false;
        public T Result { get; set; }
        public IEnumerable<string> Errors { get; set; }
        private List<string> errors { get; set; }

        protected NegocioResult()
        {
        }
        public NegocioResult(params string[] errors)
        {
            Succeeded = false;
            Result = null;
            Errors = errors.AsEnumerable();
        }

        public NegocioResult(Exception e)
        {
            Succeeded = false;
            Result = null;
            Errors = GetErrorMessages(e);            
        }


        public static NegocioResult<T> Succeded(T result = null)
        {
            return new NegocioResult<T>()
            {
                Succeeded = true,
                Result = result,
                Errors = null
            };
        }

        public IEnumerable<string> GetErrorMessages(Exception e)
        {
            if(errors == null)
                errors = new List<string>();

            errors.Add(e.Message);
            if (e.InnerException != null)
            {
                GetErrorMessages(e.InnerException);
            }
            return errors;
        }
    }
}
