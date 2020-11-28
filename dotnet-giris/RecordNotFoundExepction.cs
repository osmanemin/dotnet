using System;

namespace dotnet
{
    public class RecordNotFoundExepction : Exception
    {
        public RecordNotFoundExepction(string message):base(message){
            
        }
    }
}