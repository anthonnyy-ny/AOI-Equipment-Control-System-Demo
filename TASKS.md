# Development Tasks

## Phase 1 - 项目初始化

- [ ] 建立 C# WinForms project
- [ ] 建立资料夹结构：Forms, Models, Services, Config, Logs, Images, Results
- [ ] 新增 MachineState enum
- [ ] 新增 Recipe model
- [ ] 新增 InspectionResult model
- [ ] 新增 LoggerService
- [ ] 新增 README 项目简介

## Phase 2 - 基础 HMI

- [ ] 新增 Initialize button
- [ ] 新增 Start Auto button
- [ ] 新增 Stop button
- [ ] 新增 Reset button
- [ ] 新增 Clear Alarm button
- [ ] 新增 machine status label
- [ ] 新增 log display area
- [ ] 新增 result table
- [ ] 新增 parameter display area

## Phase 3 - Recipe 管理

- [ ] 新增 recipe.json
- [ ] 新增 RecipeService
- [ ] 从 JSON 读取 recipe
- [ ] 在 UI 显示 recipe
- [ ] 将 recipe 修改储存回 JSON

## Phase 4 - State Machine

- [ ] 新增 MachineService
- [ ] 实作状态转换逻辑
- [ ] 实作 Initialize flow
- [ ] 实作 Start Auto flow
- [ ] 实作 Stop flow
- [ ] 实作 Reset flow
- [ ] 加入 alarm transition

## Phase 5 - TCP Device Simulator

- [ ] 新增 TCP client service
- [ ] 新增 device simulator server
- [ ] 从 controller 发送 command 到 simulator
- [ ] 接收 OK / DONE / ERROR response
- [ ] 加入 timeout handling
- [ ] 加入 retry handling
- [ ] 在 UI 显示 communication log

## Phase 6 - AOI Image Inspection

- [ ] 安装 OpenCvSharp
- [ ] 新增 ImageProcessingService
- [ ] 读取 sample image
- [ ] 裁切 ROI
- [ ] 转成 grayscale
- [ ] 执行 threshold
- [ ] 找 contours
- [ ] 计算 area
- [ ] 判断 OK / NG
- [ ] 储存 processed image

## Phase 7 - 结果输出

- [ ] 新增 ResultExportService
- [ ] 输出 inspection result 到 CSV
- [ ] 储存 log file
- [ ] 储存 processed image path
- [ ] 在 DataGridView 显示 result

## Phase 8 - 文件整理

- [ ] 更新 README
- [ ] 加入 screenshots
- [ ] 加入 system flow diagram
- [ ] 加入 state machine 说明
- [ ] 加入 communication protocol 说明

