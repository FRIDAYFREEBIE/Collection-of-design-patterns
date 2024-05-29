using System.Collections.Generic;

class ChannelComposite : IChannel
{
    // IChannel 객체들을 저장하는 리스트
    private List<IChannel> channels = new List<IChannel>();
 
    // 리스트에 있는 IChannel 객체를 모두 순회하며 Show() 메서드를 호출
    public void Show() {
        foreach (IChannel channel in channels)
        {
            channel.Show();
        }
    }
 
    // channels 리스트에 IChannel 객체를 추가하는 메서드
    public void add(IChannel channel) {
        channels.Add(channel);
    }
 
    // channels 리스트에 IChannel 객체를 제거하는 메서드
    public void remove(IChannel channel) {
        channels.Remove(channel);
    }
}
