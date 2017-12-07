using System;
using Newtonsoft.Json;

namespace ChinaArea {
    public class DataItem {
        [JsonProperty("quHuaDaiMa")]
        public int QuHuaDaiMa { get; set; }

        public int ParentId { get; set; }

        [JsonProperty("shengji")]
        public string ShengJi { get; set; }

        public string Name {
            get {
                if (!string.IsNullOrWhiteSpace(XianJi)) {
                    return XianJi;
                } else if (!string.IsNullOrWhiteSpace(DiJi)) {
                    return DiJi;
                } else if (!string.IsNullOrWhiteSpace(ShengJiName)) {
                    return ShengJiName;
                } else {
                    return null;
                }
            }
        }

        public string ShengJiName {
            get {
                if (!string.IsNullOrWhiteSpace(ShengJi)) {
                    var x = ShengJi.IndexOf("(", StringComparison.CurrentCultureIgnoreCase);
                    if (x != -1) {
                        return ShengJi.Substring(0, x);
                    }
                }
                return ShengJi;
            }
        }

        public string ShengJiSortName {
            get {
                if (!string.IsNullOrWhiteSpace(ShengJi)) {
                    return StringUtils.Between(ShengJi, "(", ")");
                }

                return null;
            }
        }

        [JsonProperty("diji")]
        public string DiJi { get; set; }

        [JsonProperty("xianji")]
        public string XianJi { get; set; }


        [JsonProperty("quhao")]
        public string QuHao { get; set; }

        public string ZhuDi { get; set; }
        public string RenKou { get; set; }
        public string MianJi { get; set; }
        public string YouBian { get; set; }


        public override string ToString() {
            return string.Join(" ", QuHuaDaiMa, ParentId, ShengJi, DiJi, XianJi);
        }
    }
}