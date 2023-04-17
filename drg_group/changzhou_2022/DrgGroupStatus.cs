using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace drg_group
{
    public enum DrgGroupStatus{
        [Description("信息校验不通过")]
        CHECK_FAILED,
        [Description("信息校验通过")]
        CHECK_SUCCESS,
        [Description("分组成功")]
        SUCCESS,
        [Description("无法入组")]
        FAIL,
        [Description("诊断不能转换为分组器支持的编码")]
        ZD_NOT_MAPPING,
        [Description("手术操作不能转换为分组器支持的编码")]
        SS_NOT_MAPPING,
        [Description("歧义病案")]
        QY
    }
    public static class Common
    {
        public static string GetDescription(this Enum enumValue){
            FieldInfo fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
            DescriptionAttribute[] attrs =
                fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            return attrs.Length > 0 ? attrs[0].Description : enumValue.ToString();
        }
    }

}