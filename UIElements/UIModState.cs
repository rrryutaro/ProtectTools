using Terraria.UI;

namespace ProtectTools
{
    class UIModState : UIState
	{
		internal UserInterface userInterface;

		public UIModState(UserInterface userInterface)
		{
			this.userInterface = userInterface;
		}

        public virtual string SaveJsonString()
        {
            return string.Empty;
        }
        public virtual void LoadJsonString(string jsonString)
        {
        }
    }
}
