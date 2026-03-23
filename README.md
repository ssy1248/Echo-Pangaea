<div align="center">

# 🌍 에코 판게아 (Echo Pangaea)

**서브컬처 오픈월드 액션 + 생존 자동화 크래프팅 RPG**

![Unity](https://img.shields.io/badge/Unity-100000?style=flat-square&logo=unity&logoColor=white)
![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white)
![Status](https://img.shields.io/badge/Status-Prototyping-blue?style=flat-square)

</div>

<br>

## 📖 프로젝트 소개
**<에코 판게아>**는 광활한 심리스 오픈월드를 탐험하며 매력적인 동료('에코')들을 수집하고, 점령한 구역을 바탕으로 거대한 자동화 생산 기지를 구축하는 3D 액션 RPG입니다. 역동적인 태그 액션의 쾌감과, 복잡한 공장 라인을 설계하고 최적화하는 성취감을 동시에 제공하는 것을 목표로 개발 중인 1인 클라이언트 개인 프로젝트입니다.

<br>

## ✨ 핵심 플레이 경험 (Key Features)

### ⚔️ 스타일리시 태그 액션 & 입체적 탐험
* 3인 1조 스쿼드 기반의 빠르고 역동적인 실시간 전투
* 캐릭터 교체 및 QTE 연계 스킬을 활용한 전략적 전투 시스템
* 글라이딩, 로프 액션, 벽 타기 등 입체적인 이동기를 통한 자유로운 심리스 오픈월드 개척

### ⚙️ 코어 랜드 (Core Land) 자동화 물류망
* 오픈월드 자원 노드 점령 후, 컨베이어 벨트 및 운송 드론을 배치하여 자원 채집 자동화 구축
* 기초 자원 가공부터 최상위 장비 생산까지 이어지는 정교한 팩토리 빌딩
* 규모가 커질수록 발생하는 몬스터 웨이브와 이를 막기 위한 기지 디펜스 요소 결합

### 👯 매력적인 동료 '에코' 시스템
* 전투 스킬과 기지 관리(채굴, 전력 등)에 각기 다른 특화 능력을 지닌 캐릭터 라인업
* 플레이어의 상호작용에 따라 해금되는 개별 스토리 및 고유 임무

<br>

## 🛠 기술 스택 및 아키텍처 (Tech Stack)

### 💻 Engine & Language
* **Engine:** Unity 202X.X (LTS)
* **Language:** C#
* **Rendering:** URP (Universal Render Pipeline) 기반 고품질 카툰 렌더링(Toon Shading) 구현 및 최적화

### ⚙️ Core Systems
* **World Management:** `Addressables` 시스템을 활용한 에셋 비동기 로딩 및 청크(Chunk) 기반 메모리 관리로 심리스 환경 구현.
* **Camera & Control:** `Cinemachine`을 통한 탐험 숄더뷰와 전투 타겟팅 간의 매끄러운 트랜지션, `Input System`을 적용한 크로스플랫폼 조작 대응.
* **Optimization:** 대규모 자원 운송 및 수백 개의 공장 컨베이어 벨트 연산 부하를 줄이기 위한 데이터 지향적 접근(DOTS/Job System 등) 일부 차용.

<br>

## 🗺️ 개발 마일스톤 (Roadmap)

- [x] **Phase 1: 코어 프로토타이핑**
  - [ ] 플레이어 상태 머신(FSM) 및 기본 이동/전투 로직 구현
  - [ ] 카메라 컨트롤러 셋업 및 지시선(Indicator) 동기화
- [ ] **Phase 2: 월드 & 시스템 통합** - [ ] 맵 청크 로딩 테스트 및 1차 자동화 생산 라인 구축
- [ ] **Phase 3: 폴리싱 및 데모 빌드**
  - [ ] 스킬 연계 추가, UI/UX 개선 및 최적화
- [ ] **Phase 4: 버티컬 슬라이스 완성**
  - [ ] G-STAR 등 오프라인 인디 게임쇼 및 전시회 출품용 데모 빌드 완성

<br>

## 🚀 빌드 및 실행 방법 (Getting Started)
1. 본 레포지토리를 로컬 환경에 클론합니다.
   ```bash
   git clone [https://github.com/Username/EchoPangaea.git](https://github.com/Username/EchoPangaea.git)
