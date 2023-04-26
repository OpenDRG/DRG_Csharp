namespace drg_group.linfen_2022
{
    public class MDCO_DRG 
    {
    
        public static bool OD29_group(MedicalRecord record){
            return true;
        }
    
        public static bool OE19_group(MedicalRecord record){
            return true;
        }
    
        public static bool OF19_group(MedicalRecord record){
            return true;
        }
    
        public static bool OF29_group(MedicalRecord record){
            return true;
        }
    
        public static bool OR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool OS29_group(MedicalRecord record){
            return true;
        }
    
        public static bool OT19_group(MedicalRecord record){
            return true;
        }
    
        public static bool OB11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool OD11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool OZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool OC13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool OD13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool OJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool OS13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool OB15_group(MedicalRecord record){
            return true;
        }
    
        public static bool OC15_group(MedicalRecord record){
            return true;
        }
    
        public static bool OD15_group(MedicalRecord record){
            return true;
        }
    
        public static bool OJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool OS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool OZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
