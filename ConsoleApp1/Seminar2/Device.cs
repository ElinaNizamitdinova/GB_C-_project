using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_tasks.Seminar2
{
    //Предположим, у вас есть некоторый набор устройств, каждое из которых может быть включено или выключено, 
    //и вы хотите иметь возможность выполнять операции над этими устройствами через битовые операторы.
    public class Device : IControllable
    {
        public bool isOn { get; set; } = false;
        public void Off()
        {
            isOn = false; ;
           
        }

        public void On()
        {
            isOn = true;
           

        }
    }
    public interface IControllable
    {
        bool isOn { get; }
        void On();
        void Off();

    }
    public class Devices
    {
        public List<IControllable> ListDevices { get; set; }
        public Devices()
        {
            ListDevices = [new Device(), new Device(), new Device(), new Device(), new Device(), new Device(), new Device(), new Device()];
        }

        public void TurnOnOff(Bits bits)
        {
            for (byte i = 0; i < 8; i++)
            {

                {
                    if (ListDevices[i].isOn && !bits[i])
                    { ListDevices[i].Off(); }
                    else if (!ListDevices[i].isOn && bits[i])
                    { ListDevices[i].On(); }

                }
            }
        }
        public override string ToString()
        {
            return string.Join(" ", ListDevices.Select(s=> s.isOn?"1":"0"));
        }
    }
}