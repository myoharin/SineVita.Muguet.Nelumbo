namespace SineVita.Muguet.Nelumbo.Identity.Movement
{
    public enum CmMovementIdentityEnum
    {
        mDm3m,
        mDM3m,
        mUm3m,
        mUM3m,
        mDm3M,
        mDM3M,
        mUm3M,
        mUM3M,
        MDm3m,
        MDM3m,
        MUm3m,
        MUM3m,
        MDm3M,
        MDM3M,
        MUm3M,
        MUM3M
    }
    
    public class CmMovementIdentity : Identity
    {
        private CmMovementIdentityEnum _value;
        public CmMovementIdentityEnum EnumValue => _value;
        public CmMovementIdentity(CmMovementIdentityEnum value) {
            _value = value;
        }
        
        public override string ToString() => _value.ToString();
    }
}