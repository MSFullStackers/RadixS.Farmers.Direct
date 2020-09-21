using Volo.Abp.Settings;

namespace RadixS.Farmers.Direct.Settings
{
    public class DirectSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(DirectSettings.MySetting1));
        }
    }
}
