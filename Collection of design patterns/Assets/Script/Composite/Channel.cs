using UnityEngine;

class Channel : IChannel
{
	private string message; // 출력 할 메세지
    
    // 채널 생성자
    public Channel(string message)
    {
        this.message = message;
    }
 
    // 메세지 출력
    public void Show() {
        Debug.Log(message);
    }
}
