namespace Blackjack.Domain.PublicIF
{
    /// <summary>
    /// ゲームの一連のフローを提供します。
    /// </summary>
    public interface IGameService
    {
        /// <summary>
        /// ゲームを実行します。
        /// </summary>
        /// <returns>勝者のオブジェクト</returns>
        IPlayable Execute();

        /// <summary>
        /// ゲームを初期化します。
        /// </summary>
        void Init();
    }
}
