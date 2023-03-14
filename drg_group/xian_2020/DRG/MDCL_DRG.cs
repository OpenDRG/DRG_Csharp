namespace drg_group.xian_2020
{
    public class MDCL_DRG 
    {
    
        public static bool LA19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LB19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LC19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LD19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LK19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LL19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LS19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LU19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LY19_group(MedicalRecord record){
            return true;
        }
    
        public static bool LF11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LJ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LR11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LW11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LX11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool LF13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LR13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LT13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LW13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LX13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LZ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool LF15_group(MedicalRecord record){
            return true;
        }
    
        public static bool LJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool LR15_group(MedicalRecord record){
            return true;
        }
    
        public static bool LT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool LW15_group(MedicalRecord record){
            return true;
        }
    
        public static bool LX15_group(MedicalRecord record){
            return true;
        }
    
        public static bool LZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
