using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı adresi boş geçilemez ");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konuyu boş geçemezsiniz");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Messajı boş geçemezsiniz");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("100 karakterden fazla giriş yapamazsınız");
            //buraya geçerli mail olması gerektiğini entegre edilecek
            RuleFor(x => x.SenderMail).EmailAddress().WithMessage("Geçerli bir mail giriniz");
            RuleFor(x=>x.Subject).MinimumLength(3).WithMessage("En az 3 karkter girlişi yapmalısınız");

        }
    }
}
