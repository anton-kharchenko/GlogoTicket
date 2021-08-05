﻿using System;
using System.Collections.Generic;
using FluentValidation.Results;

namespace GloboTicket.TicketManagement.Application.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<string> ValidationErrors { get; set; }

        public ValidationException(ValidationResult result)
        {
            ValidationErrors = new List<string>();
            
            foreach (var validationError in result.Errors)
            {
                ValidationErrors.Add(validationError.ErrorMessage);
            }
        }
    }
}