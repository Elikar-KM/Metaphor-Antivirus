import "pe"
import "math"

private rule IsPE // credits to Rachid AZ
{
  condition:
     
     uint16(0) == 0x5A4D  and              // MZ
     uint32(uint32(0x3C)) == 0x00004550    // PE
}

rule Detect_Ransomware // simple example, i am still learning
{

    meta:
        author = "Metaphor Antivirus"
        confidence = "low"
	    category = "Malicious.Ransomware"
        description = "is a type of malware that threatens to publish the victim's data or perpetually block access to it unless a ransom is paid."

    strings:
	$ransomware1 = "Pay" nocase						 //  detecting ransomwares | w/ strings
	$ransomware2 = "Recover files" nocase			 //  detecting ransomwares | w/ strings
	$ransomware3 = "Encrypted" nocase				 //  detecting ransomwares | w/ strings
	$ransomware4 = "follow the instructions" nocase  //  detecting ransomwares | w/ strings
	$ransomware5 = "ransom" nocase                   //  detecting ransomwares | w/ strings
    $ransomware6 = "decrypt files" nocase            //  detecting ransomwares | w/ strings
       	

    condition:
       IsPE and 
       ( 4 of ($ransomware*) )  
}