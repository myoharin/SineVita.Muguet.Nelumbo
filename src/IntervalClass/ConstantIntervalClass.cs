namespace SineVita.Muguet.Nelumbo.IntervalClass
{
    public sealed class ConstantIntervalClass : FormalIntervalClassification
    {
        public ConstantInterval Interval { init; get; }

        public ConstantIntervalClass(ConstantInterval interval) {
            Interval = interval;
        }

        public override bool Equals(FormalIntervalClassification? other) {
            if (other is ConstantIntervalClass constant) {
                return this.Interval == constant.Interval;
            }

            return false;
        }

        public override string ToString() => this.Interval.ToString();
        public override int GetHashCode() => (int)Interval * 89;
    }
}