using System;

namespace DevFreela.core.Services
{


public interface IMessageBusService
{
    // fila para qual quer publicar a msg, e a mssegaem em bytes
    void Publish(string queue, byte[] message);
}

}