using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal interface IRemoteControl
    {

        //인터페이스는 쿠상 메서드만 갖는다.
        public abstract void PowerOn(); 
        public abstract void PowerOff();

        public void ChUP();  
        public void ChDown();

        public void SoundUp();
        public void SoundDown();
    }
}
