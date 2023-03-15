namespace drg_group.changsha_2023
{
    public class MDCC_DRG 
    {
    
        public static bool CB49_group(MedicalRecord record){
            return true;
        }
    
        public static bool CR19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CV19_group(MedicalRecord record){
            return true;
        }
    
        public static bool CD1A_CS_group(MedicalRecord record){
            return record.age<=6;
        }
    
        public static bool CD1B_CS_group(MedicalRecord record){
            return true;
        }
    
        public static bool CB11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool CB31_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool CS11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool CT11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool CU11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool CW11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool CX11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool CZ11_group(MedicalRecord record){
            return record.zdList.Length>1 && Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]);
        }
    
        public static bool CB23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CC13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CD23_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CJ13_group(MedicalRecord record){
            return record.zdList.Length>1 && (Base.has_mcc(record.Index,record.zdList[0],record.zdList[1..]) || Base.has_cc(record.Index,record.zdList[0],record.zdList[1..]));
        }
    
        public static bool CB15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CB25_group(MedicalRecord record){
            return true;
        }
    
        public static bool CB35_group(MedicalRecord record){
            return true;
        }
    
        public static bool CC15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CD25_group(MedicalRecord record){
            return true;
        }
    
        public static bool CJ15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CS15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CT15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CU15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CW15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CX15_group(MedicalRecord record){
            return true;
        }
    
        public static bool CZ15_group(MedicalRecord record){
            return true;
        }
    
    }
}
