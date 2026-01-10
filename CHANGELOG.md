# v.0.1.0 | Initial Release & Architecture Setup

### Features

- **Performance Profiling**: 실시간 FPS 및 ms 단위 프레임 타임 측정 기능을 추가했습니다.
- **Warmup System**: 씬 로드 직후 발생하는 프레임 드랍이 통계에 영향을 주지 않도록 측정 대기 시간(Warmup Time) 기능을 도입했습니다.
- **Statistical Analysis**:
    - 단순 평균이 아닌, 상/하위 일정 비율을 제외하고 계산하는 **Outlier Filtering** 기능을 추가하여 통계의 신뢰도를 높였습니다.
    - 전체 세션 동안의 Min/Max FPS 추적 기능을 포함합니다.
- **Runtime UI**: `OnGUI`를 활용하여 별도의 Canvas 설치 없이도 화면에 성능 지표를 표시하며, 통계 초기화를 위한 리셋 버튼을 제공합니다.
- **Editor Support**: 인스펙터 컨텍스트 메뉴 및 상단 메뉴 바(`Tools > LederyCore`)를 통해 씬 내의 모든 프레임 체커를 일괄 리셋할 수 있는 기능을 추가했습니다.

### Changes

- **Assembly Definition**: 유지보수 및 컴파일 속도 최적화를 위해 `LederyCore.Utilities.FrameChecker` 어셈블리를 분리했습니다.
- **Namespace Standardization**: 모든 클래스를 `LederyCore.Utilities.FrameChecker` 네임스페이스 아래로 정리하여 코드 확장성을 확보했습니다.