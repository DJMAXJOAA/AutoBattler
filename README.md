# AutoBattler
> 유니티 엔진 개인 프로젝트
> - 기획 2023.02.28 ~ 2023.03.04
> - 개발 2023.03.19 ~

# 1. 개발 환경
- IDE: Visual Studio 2022, JetBrains Rider 2023.3
- Unity: Unity 2022.3.16f1
    - Asset 직렬화 방식: Force Text
    - Unity Version Control: Visible Meta Files
- VCS: Git, GitHub (Source Tree)
<br/>

# 2. 업무 관리
-  [프로젝트 일정 관리 (Github Projects)](https://github.com/users/DJMAXJOAA/projects/3)
-  [문서 및 위키 (Notion)](https://patch-cook-70d.notion.site/Unity-0e2a51673b0b495997cef726842f0428?pvs=4)
-  [개발 문서, 회고 (velog)](https://velog.io/@cpsn6237/Unity-%EC%98%A4%ED%86%A0%EB%B0%B0%ED%8B%80%EB%9F%AC-%EA%B0%9C%EC%9D%B8-%ED%94%84%EB%A1%9C%EC%A0%9D%ED%8A%B8)

# 3. 브랜치 전략
- Git Flow
  - `main`  배포본
  - `develop` 개발 작업
  - `feature` 특정 기능 작업

 # 4. 커밋 컨벤션
- `feat` 새로운 기능 추가
- `fix` 버그 수정
- `docs` 문서 수정
- `style` 스타일 관련 수정 (코드 기능 변경 X)
- `refactor` 코드 리팩토링
- `test` 테스트 코드 추가, 수정
- `chore` 빌드 관련 수정, 모듈 추가 등 설정 관련 (코드 변경X)

# 5. 유니티 폴더 컨벤션
```
Assets
+---Art
| +---Animations
| +---Audio
|    +---Musics
|    +---Sounds
| +---Materials
| +---Models
| +---Textures
+---Level
| +---Prefabs
| +---Scenes
| +---UI
|    +---Fonts
+---Plugins
+---ScriptableObjects
+---Scripts
+---Settings
```
