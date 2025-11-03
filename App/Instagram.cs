public class Instagram{

    public void EnviarMensagem(string numero, TextMessage){

        Console.WriteLine($"Enviando mensagem de texto para o número {numero}")
    }
    public void EnviarMensagem(string numero, PhotoMessage){

        Console.WriteLine($"Enviando mensagem de texto para o número {numero}")
    }
    

    public void EnviarMensagem(string numero, VideoMessage){

        Console.WriteLine($"Enviando mensagem de texto para o número {numero}")
    }


        public void EnviarMensagem(string numero, FileMessage){

        Console.WriteLine($"Enviando mensagem de texto para o número {numero}")
    }
}