
private void eBSToolStripMenuItem_Click(object sender, EventArgs e)
{
    string sub = "Kayıt Formu";
    string bod = "";
    bod += "Ad Soyad : EBS ";
    bod += "<br/>Telefon : 0541154151kk";
    bod += "<br/>E-Posta : test ";
    bod += "<br/>Seçimler : dfgdfgdfg ";
    sendMailbyGMAIL(sub, bod);
}
//Mesaj Yollama Tetodu
public void sendMailbyGMAIL(string subject, string body)
{

    SmtpClient client = new SmtpClient();
    client.DeliveryMethod = SmtpDeliveryMethod.Network;
    client.EnableSsl = true;
    client.Host = "admin.com";
    client.Port = 587;

    System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("admin@admin.com", "passwd");
    client.UseDefaultCredentials = false;
    client.Credentials = credentials;

    MailMessage msg = new MailMessage();
    msg.From = new MailAddress("info@admin.com");
    msg.To.Add(new MailAddress("info@admin.com"));

    msg.Subject = subject;
    msg.IsBodyHtml = true;
    msg.Body = string.Format(body);
    client.Send(msg);
}
