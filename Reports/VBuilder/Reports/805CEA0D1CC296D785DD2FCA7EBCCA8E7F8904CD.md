![mdb](https://user-images.githubusercontent.com/6315083/192282485-b77f3080-0b6b-4624-b85e-1c619cc2441a.png)
# WET - WET.exe
## Informations
| Label | Value |
| :--- | ---: |
| Executable Name | WET.exe |
| Product Name | WET |
| Version Number | 2.00 |
| Description | WalruS Encryption Tool (WET) |
| Company Name | Wally Tools |
| Copyright |  |
| Trademarks | Wally & WalruS (c) Wally Tools |
| Last Edition | 24/04/2001 23:14:28 |
| Size | 225280 |
| SHA1 🔎 | [805CEA0D1CC296D785DD2FCA7EBCCA8E7F8904CD](https://www.virustotal.com/gui/search/805CEA0D1CC296D785DD2FCA7EBCCA8E7F8904CD) |
| Language | English (United States) |
## Static Analysis
<details>
<summary>Manalyze</summary>
<p>

```

* Manalyze 0.9 *

-------------------------------------------------------------------------------
C:/Users/IEUser/Desktop/net6.0/Malwares/WET/WET/WET.exe
-------------------------------------------------------------------------------

Summary:
--------
Architecture:       IMAGE_FILE_MACHINE_I386
Subsystem:          IMAGE_SUBSYSTEM_WINDOWS_GUI
Compilation Date:   2001-Apr-24 22:14:27
Detected languages: English - United States
CompanyName:        Wally Tools
FileDescription:    WalruS Encryption Tool (WET)
LegalTrademarks:    Wally & WalruS (c) Wally Tools
ProductName:        WET
FileVersion:        2.00
ProductVersion:     2.00
InternalName:       WET
OriginalFilename:   WET.exe

DOS Header:
-----------
e_magic:    MZ
e_cblp:     0x0090
e_cp:       0x0003
e_crlc:     0x0000
e_cparhdr:  0x0004
e_minalloc: 0x0000
e_maxalloc: 0xFFFF
e_ss:       0x0000
e_sp:       0x00B8
e_csum:     0x0000
e_ip:       0x0000
e_cs:       0x0000
e_ovno:     0x0000
e_oemid:    0x0000
e_oeminfo:  0x0000
e_lfanew:   0x000000C8

PE Header:
----------
Signature:            PE
Machine:              IMAGE_FILE_MACHINE_I386
NumberofSections:     3
TimeDateStamp:        2001-Apr-24 22:14:27
PointerToSymbolTable: 0x00000000
NumberOfSymbols:      0
SizeOfOptionalHeader: 0x00E0
Characteristics:      IMAGE_FILE_32BIT_MACHINE
                      IMAGE_FILE_EXECUTABLE_IMAGE
                      IMAGE_FILE_LINE_NUMS_STRIPPED
                      IMAGE_FILE_LOCAL_SYMS_STRIPPED
                      IMAGE_FILE_RELOCS_STRIPPED

Image Optional Header:
----------------------
Magic:                   PE32
LinkerVersion:           6.0
SizeOfCode:              0x00034000
SizeOfInitializedData:   0x00004000
SizeOfUninitializedData: 0x00000000
AddressOfEntryPoint:     0x00001578 (Section: .text)
BaseOfCode:              0x00001000
BaseOfData:              0x00035000
ImageBase:               0x00400000
SectionAlignment:        0x00001000
FileAlignment:           0x00001000
OperatingSystemVersion:  4.0
ImageVersion:            2.0
SubsystemVersion:        4.0
Win32VersionValue:       0
SizeOfImage:             0x00039000
SizeOfHeaders:           0x00001000
Checksum:                0x00042031
Subsystem:               IMAGE_SUBSYSTEM_WINDOWS_GUI
SizeofStackReserve:      0x00100000
SizeofStackCommit:       0x00001000
SizeofHeapReserve:       0x00100000
SizeofHeapCommit:        0x00001000
LoaderFlags:             0x00000000
NumberOfRvaAndSizes:     16

Sections:
---------
.text:
    VirtualSize:          0x00033B04
    VirtualAddress:       0x00001000
    SizeOfRawData:        0x00034000
    PointerToRawData:     0x00001000
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_CODE
                          IMAGE_SCN_MEM_EXECUTE
                          IMAGE_SCN_MEM_READ
    Entropy:              7.83332

.data:
    VirtualSize:          0x0000208C
    VirtualAddress:       0x00035000
    SizeOfRawData:        0x00001000
    PointerToRawData:     0x00035000
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE
    Entropy:              0

.rsrc:
    VirtualSize:          0x00000C70
    VirtualAddress:       0x00038000
    SizeOfRawData:        0x00001000
    PointerToRawData:     0x00036000
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
    Entropy:              3.06952


Imports:
--------
MSVBVM60.DLL: #690
              _CIcos
              _adj_fptan
              __vbaVarMove
              __vbaFreeVar
              __vbaEnd
              __vbaFreeVarList
              _adj_fdiv_m64
              _adj_fprem1
              __vbaStrCat
              __vbaHresultCheckObj
              __vbaLenVar
              _adj_fdiv_m32
              __vbaVarForInit
              __vbaStrBool
              #595
              __vbaOnError
              __vbaObjSet
              _adj_fdiv_m16i
              __vbaObjSetAddref
              _adj_fdivr_m16i
              _CIsin
              #632
              __vbaChkstk
              EVENT_SINK_AddRef
              __vbaVarTstEq
              _adj_fpatan
              EVENT_SINK_Release
              #600
              _CIsqrt
              EVENT_SINK_QueryInterface
              __vbaExceptHandler
              _adj_fprem
              _adj_fdivr_m64
              #608
              __vbaFPException
              __vbaStrVarVal
              __vbaVarCat
              #534
              _CIlog
              __vbaNew2
              _adj_fdiv_m32i
              _adj_fdivr_m32i
              __vbaFreeStrList
              _adj_fdivr_m32
              _adj_fdiv_r
              #100
              __vbaVarTstNe
              __vbaI4Var
              #689
              __vbaVarAdd
              __vbaVarDup
              _CIatan
              __vbaStrMove
              _allmul
              _CItan
              __vbaVarForNext
              _CIexp
              __vbaFreeStr
              __vbaFreeObj

Resources:
----------
30001:
    Type:          RT_ICON
    Language:      UNKNOWN
    Codepage:      Unicode (UTF 16LE)
    Size:          2216
    TimeDateStamp: 2001-Apr-24 22:14:27
    Entropy:       3.34222

1:
    Type:              RT_GROUP_ICON
    Language:          UNKNOWN
    Codepage:          Unicode (UTF 16LE)
    Size:              20
    TimeDateStamp:     2001-Apr-24 22:14:27
    Entropy:           2.22322
    Detected Filetype: Icon file

1 (#2):
    Type:          RT_VERSION
    Language:      English - United States
    Codepage:      Unicode (UTF 16LE)
    Size:          708
    TimeDateStamp: 2001-Apr-24 22:14:27
    Entropy:       3.27094


Version Info:
-------------
Resource LangID: English - United States
VS_VERSION_INFO:
    Signature:           0xFEEF04BD
    StructVersion:       0x00010000
    FileVersion:         2.0.0.0
    ProductVersion:      2.0.0.0
    FileFlags:           (EMPTY)
    FileOs:              VOS_DOS_WINDOWS32
                         VOS_NT_WINDOWS32
                         VOS__WINDOWS32
    FileType:            VFT_APP
    Language:            English - United States
    CompanyName:         Wally Tools
    FileDescription:     WalruS Encryption Tool (WET)
    LegalTrademarks:     Wally & WalruS (c) Wally Tools
    ProductName:         WET
    FileVersion (#2):    2.00
    ProductVersion (#2): 2.00
    InternalName:        WET
    OriginalFilename:    WET.exe


RICH Header:
------------
XOR Key:          0x8917A389
Unmarked objects: 0
14 (7299):        1
9 (8041):         4
13 (8169):        1

Matching compiler(s):
    Microsoft Visual Basic v5.0/v6.0
    Microsoft Visual Basic v5.0 - v6.0
    Microsoft Visual Basic v6.0

[ SUSPICIOUS ] Strings found in the binary may indicate undesirable behavior:
    Miscellaneous malware strings:
        Virus
    Contains domain names:
        WalruS.8k.com
        http://www.WalruS.8k.com
        iamit.com
        www.WalruS.8k.com

The following exploit mitigation techniques have been detected
    Stack Canary: disabled
    SafeSEH: disabled
    ASLR: disabled
    DEP: disabled
    CFG: disabled




```

</p>
</details>

## Screenshots
### The Walrus Encryption Tool (WET)
![UI](./Screenshots/WET_The%20Walrus%20Encryption%20Tool%20(WET)_cb75b7712f6e41f194b9d4f8b6dfbfe2.png) 
