﻿using mobSocial.Data.Entity.Emails;
using mobSocial.WebApi.Models.Emails;

namespace mobSocial.WebApi.Extensions.ModelExtensions
{
    public static class EmailExtensions
    {
        public static EmailAccountEntityModel ToEntityModel(this EmailAccount emailAccount)
        {
            var model = new EmailAccountEntityModel()
            {
                Id = emailAccount.Id,
                Email = emailAccount.Email,
                UserName = emailAccount.UserName,
                FromName = emailAccount.FromName,
                IsDefault = emailAccount.IsDefault,
                Host = emailAccount.Host,
                UseSsl = emailAccount.UseSsl,
                Port = emailAccount.Port,
                UseDefaultCredentials = emailAccount.UseDefaultCredentials
            };
            return model;
        }

        public static EmailTemplateEntityModel ToEntityModel(this EmailTemplate emailTemplate)
        {
            var model = new EmailTemplateEntityModel()
            {
                Id = emailTemplate.Id,
                AdministrationEmail = emailTemplate.AdministrationEmail,
                EmailAccountId = emailTemplate.EmailAccountId,
                IsMaster = emailTemplate.IsMaster,
                ParentEmailTemplateId = emailTemplate.ParentEmailTemplateId,
                Subject = emailTemplate.Subject,
                Template = emailTemplate.Template,
                TemplateName = emailTemplate.TemplateName,
                TemplateSystemName = emailTemplate.TemplateSystemName
            };
            return model;
        }   
    }
}