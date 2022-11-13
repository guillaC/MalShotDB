![mdb](https://user-images.githubusercontent.com/6315083/192282485-b77f3080-0b6b-4624-b85e-1c619cc2441a.png)
# Client - Backdoor.Win32.Ullysee.a-7679fbbc1ee1ab20b8335de506ce8635de561596308500e5cda2928461bbc5cc.exe
## Informations
| Label | Value |
| :--- | ---: |
| Executable Name | Backdoor.Win32.Ullysee.a-7679fbbc1ee1ab20b8335de506ce8635de561596308500e5cda2928461bbc5cc.exe |
| Product Name | Client |
| Version Number | 0.00.0001 |
| Description |  |
| Company Name | yey |
| Copyright |  |
| Trademarks |  |
| Last Edition | 14/06/2012 09:49:54 |
| Size | 151552 |
| SHA1 🔎 | [9AF97E1FCF01277CA0BCE7A6E18F9FEB2CC0D6FA](https://www.virustotal.com/gui/search/9AF97E1FCF01277CA0BCE7A6E18F9FEB2CC0D6FA) |
| Language | French (France) |
## Static Analysis
<details>
<summary>Manalyze</summary>
<p>

```

* Manalyze 0.9 *

-------------------------------------------------------------------------------
C:/Users/IEUser/Desktop/net6.0/Malwares/Backdoor.Win32.Ullysee.a-7679fbbc1ee1ab20b8335de506ce8635de561596308500e5cda2928461bbc5cc.exe
-------------------------------------------------------------------------------

Summary:
--------
Architecture:       IMAGE_FILE_MACHINE_I386
Subsystem:          IMAGE_SUBSYSTEM_WINDOWS_GUI
Compilation Date:   2000-Aug-06 13:39:26
Detected languages: French - France
Comments:           Version Beta
CompanyName:        yey
ProductName:        Client
FileVersion:        0.00.0001
ProductVersion:     0.00.0001
InternalName:       Ullysse
OriginalFilename:   Ullysse.exe

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
e_lfanew:   0x000000C0

PE Header:
----------
Signature:            PE
Machine:              IMAGE_FILE_MACHINE_I386
NumberofSections:     3
TimeDateStamp:        2000-Aug-06 13:39:26
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
SizeOfCode:              0x00022000
SizeOfInitializedData:   0x00008000
SizeOfUninitializedData: 0x00000000
AddressOfEntryPoint:     0x00001EDC (Section: .text)
BaseOfCode:              0x00001000
BaseOfData:              0x00023000
ImageBase:               0x00400000
SectionAlignment:        0x00001000
FileAlignment:           0x00001000
OperatingSystemVersion:  4.0
ImageVersion:            0.0
SubsystemVersion:        4.0
Win32VersionValue:       0
SizeOfImage:             0x0002B000
SizeOfHeaders:           0x00001000
Checksum:                0x0002E4A0
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
    VirtualSize:          0x000210A4
    VirtualAddress:       0x00001000
    SizeOfRawData:        0x00022000
    PointerToRawData:     0x00001000
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_CODE
                          IMAGE_SCN_MEM_EXECUTE
                          IMAGE_SCN_MEM_READ
    Entropy:              5.47256

.data:
    VirtualSize:          0x00006CE4
    VirtualAddress:       0x00023000
    SizeOfRawData:        0x00001000
    PointerToRawData:     0x00023000
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
                          IMAGE_SCN_MEM_WRITE
    Entropy:              0

.rsrc:
    VirtualSize:          0x00000F18
    VirtualAddress:       0x0002A000
    SizeOfRawData:        0x00001000
    PointerToRawData:     0x00024000
    PointerToRelocations: 0x00000000
    PointerToLineNumbers: 0x00000000
    NumberOfLineNumbers:  0
    NumberOfRelocations:  0
    Characteristics:      IMAGE_SCN_CNT_INITIALIZED_DATA
                          IMAGE_SCN_MEM_READ
    Entropy:              4.60189


Imports:
--------
MSVBVM60.DLL: __vbaVarSub
              __vbaStrI2
              _CIcos
              _adj_fptan
              __vbaStrI4
              __vbaVarMove
              __vbaVarVargNofree
              __vbaFreeVar
              __vbaLateIdCall
              __vbaStrVarMove
              __vbaLenBstr
              __vbaFreeVarList
              __vbaEnd
              _adj_fdiv_m64
              __vbaPut4
              __vbaFreeObjList
              _adj_fprem1
              __vbaVarCmpNe
              __vbaStrCat
              __vbaSetSystemError
              __vbaHresultCheckObj
              __vbaLenVar
              _adj_fdiv_m32
              __vbaExitProc
              __vbaVarForInit
              #595
              __vbaObjSet
              __vbaOnError
              _adj_fdiv_m16i
              __vbaObjSetAddref
              _adj_fdivr_m16i
              #598
              __vbaFpR4
              __vbaFpR8
              __vbaBoolVarNull
              __vbaVarTstLt
              _CIsin
              #525
              #632
              __vbaChkstk
              __vbaFileClose
              EVENT_SINK_AddRef
              __vbaGet3
              __vbaStrCmp
              #529
              __vbaVarTstEq
              __vbaI2I4
              DllFunctionCall
              __vbaVarOr
              __vbaStrR4
              _adj_fpatan
              __vbaR4Var
              __vbaLateIdCallLd
              __vbaStrR8
              EVENT_SINK_Release
              _CIsqrt
              __vbaVarAnd
              EVENT_SINK_QueryInterface
              __vbaVarMul
              __vbaExceptHandler
              _adj_fprem
              _adj_fdivr_m64
              #608
              __vbaFPException
              __vbaInStrVar
              __vbaStrVarVal
              __vbaVarCat
              #535
              __vbaI2Var
              _CIlog
              __vbaErrorOverflow
              __vbaFileOpen
              __vbaR8Str
              #570
              __vbaNew2
              #648
              _adj_fdiv_m32i
              _adj_fdivr_m32i
              __vbaStrCopy
              __vbaFreeStrList
              _adj_fdivr_m32
              _adj_fdiv_r
              #100
              __vbaVarTstNe
              __vbaI4Var
              __vbaVarCmpEq
              __vbaVarAdd
              __vbaStrToAnsi
              __vbaVarDup
              #613
              __vbaVarCopy
              __vbaFpI4
              #616
              #617
              _CIatan
              __vbaStrMove
              #618
              #619
              _allmul
              __vbaLateIdSt
              _CItan
              __vbaVarForNext
              _CIexp
              __vbaFreeObj
              __vbaFreeStr
              #581

Resources:
----------
30001:
    Type:          RT_ICON
    Language:      UNKNOWN
    Codepage:      Unicode (UTF 16LE)
    Size:          744
    TimeDateStamp: 2000-Aug-06 13:39:25
    Entropy:       4.10572

30002:
    Type:          RT_ICON
    Language:      UNKNOWN
    Codepage:      Unicode (UTF 16LE)
    Size:          2216
    TimeDateStamp: 2000-Aug-06 13:39:25
    Entropy:       4.52764

1:
    Type:              RT_GROUP_ICON
    Language:          UNKNOWN
    Codepage:          Unicode (UTF 16LE)
    Size:              36
    TimeDateStamp:     2000-Aug-06 13:39:25
    Entropy:           2.71877
    Detected Filetype: Icon file

1 (#2):
    Type:          RT_VERSION
    Language:      French - France
    Codepage:      Unicode (UTF 16LE)
    Size:          580
    TimeDateStamp: 2000-Aug-06 13:39:25
    Entropy:       3.1632


Version Info:
-------------
Resource LangID: French - France
VS_VERSION_INFO:
    Signature:           0xFEEF04BD
    StructVersion:       0x00010000
    FileVersion:         0.0.0.1
    ProductVersion:      0.0.0.1
    FileFlags:           (EMPTY)
    FileOs:              VOS_DOS_WINDOWS32
                         VOS_NT_WINDOWS32
                         VOS__WINDOWS32
    FileType:            VFT_APP
    Language:            French - France
    Comments:            Version Beta
    CompanyName:         yey
    ProductName:         Client
    FileVersion (#2):    0.00.0001
    ProductVersion (#2): 0.00.0001
    InternalName:        Ullysse
    OriginalFilename:    Ullysse.exe


RICH Header:
------------
XOR Key:          0x183A2CFD
Unmarked objects: 0
14 (7299):        1
9 (8041):         15
13 (8169):        1

Matching compiler(s):
    Microsoft Visual Basic v5.0/v6.0
    Microsoft Visual Basic v5.0 - v6.0
    Microsoft Visual Basic v6.0

Interesting strings found in the binary:
    Contains domain names:
        caramail.com
        http://www.multimania.com
        http://www.multimania.com/thundergun/
        multimania.com
        www.multimania.com

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
### Ullysse par Thunder_gun
![UI](./Screenshots/Client_Ullysse%20par%20Thunder_gun_fedef15a683a425ebb5243fea415f6d8.png) 
### About
![UI](./Screenshots/Client_About_1b7c061b08da47de90f0523f63913235.png) 
