// FSM 인터페이스
public interface IFSM
{
    public enum State{}; // 상태 목록
    public void UpdateState(); // 상태 갱신
}
