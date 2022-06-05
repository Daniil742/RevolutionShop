using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace AppAssistants
{
	internal class EmailHelper
	{
		private const string _senderEmail = "";
		private const string _senderName = "";

		public void Send()
		{
			int code = CodeGeneration();

			// Отправитель(почта сайта, имя отправителя).
			MailAddress sender = new MailAddress(_senderEmail, _senderName);
			// Получатель(прирегистрации и входе).
			MailAddress recipient = new MailAddress("");
			// Объект сообщения.
			MailMessage message = new MailMessage(sender, recipient);
			// Тема письма.
			message.Subject = "Код авторизации/ргистрации";
			// Текст письма.
			message.Body = $"<h2>Код автрориации: {code}</h2>";
			// Отправление письма в виде html.
			message.IsBodyHtml = true;
			// Aдрес smtp-сервера и порт, с которого будем отправлять письмо.
			SmtpClient smtp = new SmtpClient("", 0);
			// Логин и пароль.
			smtp.Credentials = new NetworkCredential(_senderEmail, "password");
			smtp.EnableSsl = true;
			smtp.Send(message);
		}

		private int CodeGeneration()
		{
			int code = 0;
			Random random = new Random();

			code = random.Next(100000, 999999);

			return code;
		}
	}
}
