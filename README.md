# sendEmailMethod
fornece uma maneira simples de enviar e-mails

1. `public class SendEmail {`: Isso define uma classe chamada `SendEmail`.

2. `public static void sendEmailMethod(String toAddress, String subject, String body)`: Esta é uma função estática chamada `sendEmailMethod` que aceita três parâmetros: `toAddress` (o endereço de e-mail de destino), `subject` (o assunto do e-mail) e `body` (o corpo do e-mail). Essa função é responsável por enviar um e-mail.

3. `Messaging.SingleEmailMessage email = new Messaging.SingleEmailMessage();`: Aqui, uma instância da classe `Messaging.SingleEmailMessage` é criada. Esta é uma classe que normalmente é usada para construir e configurar mensagens de e-mail antes de enviá-las.

4. `email.setToAddresses(new String[] {toAddress});`: Define o destinatário do e-mail usando o endereço fornecido no parâmetro `toAddress`.

5. `email.setSubject(subject);`: Define o assunto do e-mail usando o valor fornecido no parâmetro `subject`.

6. `email.setPlainTextBody(body);`: Define o corpo do e-mail usando o valor fornecido no parâmetro `body`.

7. `Messaging.sendEmail(new Messaging.SingleEmailMessage[] {email});`: Finalmente, a função `sendEmail` do objeto `Messaging` é chamada para enviar o e-mail. Ela aceita um array de `Messaging.SingleEmailMessage`, e aqui está sendo passado um array contendo apenas o objeto `email` que foi configurado anteriormente.
