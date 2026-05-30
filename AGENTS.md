# AGENTS.md

## 项目目标

这个 repository 是一个 C# WinForms 的自动光学检测设备控制系统 Demo。

目标是模拟工业自动化设备软件，包含：

- 设备 HMI 操作介面
- 机台状态控制
- Recipe 参数管理
- TCP/IP 设备通讯模拟器
- 使用 OpenCvSharp 的 AOI 影像检测
- Alarm 异常处理
- 机台 Log 记录
- CSV 检测结果输出

这个项目是为了准备光学检测 / 自动化设备软件工程师岗位的作品集。

## 技术栈

- C#
- WinForms
- .NET
- OpenCvSharp
- TCP/IP Socket
- JSON
- CSV

## 编码规则

- 使用简单、清楚、容易理解的 C# 代码。
- 保持 class 分工清楚。
- 不要把所有逻辑都写在 MainForm.cs。
- UI 逻辑、业务逻辑、通讯逻辑、影像处理逻辑要尽量分开。
- Services 资料夹放业务逻辑。
- Models 资料夹放资料模型。
- Config 资料夹放 recipe JSON。
- Logs 资料夹放机台 log。
- Results 资料夹放 CSV 和检测结果。
- Images 资料夹放 sample image 和 processed image。

## 建议资料夹结构

AOIEquipmentControlSystem/
├── Forms/
├── Models/
├── Services/
├── Config/
├── Logs/
├── Images/
└── Results/

## 主要功能

1. C# WinForms HMI 操作介面
2. 机台 State Machine
3. 使用 JSON 读取和储存 Recipe
4. TCP/IP 设备通讯模拟器
5. 使用 OpenCvSharp 进行 AOI 影像检测
6. Alarm 异常处理
7. Log 记录
8. CSV 检测结果输出

## 机台状态

请使用以下 Machine States：

- Idle
- Initializing
- Ready
- Running
- Inspecting
- Completed
- Alarm
- Stopped

## 设备自动流程

自动流程应该是：

Initialize
→ Connect Device
→ Load Recipe
→ Home
→ Move To Capture Position
→ Turn On Light
→ Capture Image
→ Run AOI Inspection
→ Save Result
→ Complete

## 开发风格

实现功能时，请遵守：

1. 先简短说明实现计划。
2. 只修改必要文件。
3. 代码保持 beginner-friendly。
4. 重要的工业自动化概念请加注释。
5. 完成后总结修改了哪些文件。
6. 说明如何运行或验证功能。

## 不要做的事情

- 不要使用真实公司资料。
- 不要使用真实机台参数。
- 不要加入密码、API Key 或私人文件。
- 不要过度设计系统。
- 除非特别要求，不要重写整个项目。
- 除非特别要求，不要使用 Web backend framework。

## 完成标准

一个功能完成时，应该满足：

- Project 可以成功 build。
- 代码有放在正确资料夹。
- UI 可以展示该功能。
- 需要时可以产生 Log 或结果输出。
- 如果功能改变使用方式，要更新 README 或 docs。