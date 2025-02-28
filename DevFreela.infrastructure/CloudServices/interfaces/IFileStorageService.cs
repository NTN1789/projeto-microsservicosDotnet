using System;

namespace DevFreela.infrastructure.CloudServices.interfaces
{


    public interface IFileStorageService
    {
        void UplodaFile(byte[] bytes, string fileName);

    }

}