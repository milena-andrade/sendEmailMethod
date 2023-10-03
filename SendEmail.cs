public class SendEmail {
    
    public static void sendEmailMethod(String toAddress, String subject, String body){
        
        Messaging.SingleEmailMessage email = new Messaging.SingleEmailMessage();
        email.setToAddresses(new String[] {toAddress});
        email.setSubject(subject);
        email.setPlainTextBody(body);
        
        Messaging.sendEmail(new Messaging.SingleEmailMessage[] {email});        
    }

}
