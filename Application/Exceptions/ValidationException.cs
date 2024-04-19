using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Application.Exceptions
{
    public class ValidationException:ApplicationException
    {
        public IDictionary<string, string[]> Errors { get; set; } 
        public ValidationException() : base("Se presentaron multiples errores") 
        {
            Errors = new Dictionary<string, string[]>();
        }

        public ValidationException(IEnumerable<ValidationFailure> failures):this()
        {
            Errors = failures
                .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
                .ToDictionary( f=>f.Key,f=>f.ToArray() );

        }
    }
}
