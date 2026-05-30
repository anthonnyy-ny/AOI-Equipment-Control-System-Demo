# AOI Equipment Control System Demo

这是一个使用 C# WinForms 建立的自动光学检测设备控制系统 Demo。

项目目标是模拟工业自动化设备软件的基础结构，作为光学检测 / 自动化设备软件工程师作品集使用。后续会逐步加入 Recipe 参数管理、TCP/IP 设备通讯模拟器、OpenCvSharp AOI 影像检测、CSV 检测结果输出等功能。

## 项目文件

- [ROADMAP.md](ROADMAP.md)：项目开发路线图，适合审核整体进度。
- [TASKS.md](TASKS.md)：开发任务 checklist，适合逐项确认完成状态。
- [PROJECT_SPEC.md](PROJECT_SPEC.md)：项目规格说明。

## 目前开发状态

目前完成 Phase 2：基础 HMI 与简单 MachineService 骨架。

已完成内容：

- 建立基础资料夹结构
- 建立 `MachineState`、`Recipe`、`InspectionResult` model
- 建立 `LoggerService`
- 建立 `MachineService`
- 建立 MainForm 基础 HMI 画面
- HMI 可以显示机台状态、设备连接状态、固定 Recipe 参数、Log 讯息和基础 Result 表格

暂时尚未实作：

- TCP/IP Device Simulator
- OpenCvSharp / AOI image inspection
- CSV export
- SQL Server
- WPF
- Deep Learning

## 项目结构

```text
AOIEquipmentControlSystem/
├── Forms/
│   ├── MainForm.cs
│   ├── MainForm.Designer.cs
│   └── MainForm.resx
├── Models/
│   ├── MachineState.cs
│   ├── Recipe.cs
│   └── InspectionResult.cs
├── Services/
│   ├── LoggerService.cs
│   └── MachineService.cs
├── Config/
│   └── recipe.json
├── Logs/
├── Images/
└── Results/
```

## HMI 功能

MainForm 目前包含：

- Initialize button
- Start Auto button
- Stop button
- Reset button
- Clear Alarm button
- Machine Status label
- Device Connection Status label
- Recipe parameter display area
- Log display area
- Result DataGridView

## 状态流程

程序启动时，机台状态为 `Idle`。

正常流程：

```text
Initialize
→ Idle → Initializing → Ready

Start Auto
→ Ready → Running → Inspecting → Completed → Ready
```

异常流程：

```text
程序启动后直接按 Start Auto
→ MachineState 进入 Alarm
→ Log 显示 Cannot start auto. Machine is not ready.
→ 按 Clear Alarm 或 Reset 回到 Idle
```

## 如何验证

在 repository 根目录执行：

```powershell
dotnet build .\AOIEquipmentControlSystem\AOIEquipmentControlSystem.csproj
```

预期结果：项目可以成功 build，且没有错误。

也可以使用 Visual Studio 打开项目后按下 Start 执行 WinForms 程序，并依照上方正常流程与异常流程测试按钮操作。
