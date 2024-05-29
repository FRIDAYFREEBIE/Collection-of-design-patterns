using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    void Start()
    {
        ShowChannel();
    }
    
    public void ShowChannel()
    {
        Channel channel1 = new Channel("1");
        Channel channel2 = new Channel("2");
        Channel channel3 = new Channel("3");
        Channel channel4 = new Channel("4");
  		Channel channel5 = new Channel("5");
        
        ChannelComposite composite1 = new ChannelComposite();
        ChannelComposite composite2 = new ChannelComposite();
        
        composite1.add(channel1);
        composite1.add(channel2);
        composite1.add(composite2);
        
        composite2.add(channel3);
        composite2.add(channel4);
        composite2.add(channel5);
        
        channel1.Show();
        
        composite1.Show();
        
        composite2.Show();
    }
}
