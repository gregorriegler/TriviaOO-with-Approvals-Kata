namespace UglyTrivia
{
    public class PenaltyBoxRollFactory : Base
    {
        private int roll;

        public PenaltyBoxRollFactory(CurrentPlayer currentPlayer, PlayerNames names, Places places, Purses purses, PenaltyBox penaltyBox, Categories categories, QuestionsByCategory questions, bool[] isGettingOutOfPenaltyBox, int roll)
            : base(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox)
        {
            this.roll = roll;
        }

        public Action Create()
        {
            if (roll % 2 != 0)
            {
                return new GettingOutRoll(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox, roll);
            }
            else
            {
                return new PenaltyBoxRoll(currentPlayer, names, places, purses, penaltyBox, categories, questions, isGettingOutOfPenaltyBox, roll);
            }
        }
    }
}
