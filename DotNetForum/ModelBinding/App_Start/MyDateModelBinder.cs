using System;
using System.Web.Mvc;

namespace ModelBinding
{
    public class SastTimeAdjustmentModelBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var bindModel = base.BindModel(controllerContext, bindingContext);
            if ((bindModel != null) && (bindModel is DateTime))
            {
                return  TimeZoneInfo.ConvertTime(((DateTime)bindModel), TimeZoneInfo.FindSystemTimeZoneById("South Africa Standard Time"), TimeZoneInfo.Utc);
                
            }

            return bindModel;
        }
    }


}