
using Lockstep.Math;
using LockstepTutorial;

namespace Lockstep.Game {
    public class BaseSystem : BaseGameService {
        public bool enable = true;
        public virtual void DoUpdate(LFloat deltaTime){ }
    }

    public abstract class BaseGameService : BaseService,IBaseGameManager {
        
        protected INetworkService _networkService;
        protected ISimulation _simulationService;
        protected IUIService _uiService;
        
        protected IGameStateService _gameStateService;
        protected IGameEffectService _gameEffectService;
        protected IGameAudioService _gameAudioService;
        protected IGameConfigService _gameConfigService;
        protected IGameEntityService _gameEntityService;
        protected IGameResourceService _gameResourceService;
        
        public override void InitReference( IServiceContainer serviceContainer,IManagerContainer mgrContainer){
            base.InitReference(serviceContainer,mgrContainer);
            
            _networkService = serviceContainer.GetService<INetworkService>();
            _simulationService = serviceContainer.GetService<ISimulation>();
            _uiService = serviceContainer.GetService<IUIService>();
            
            _gameEffectService = serviceContainer.GetService<IGameEffectService>();
            _gameAudioService = serviceContainer.GetService<IGameAudioService>();
            _gameStateService = serviceContainer.GetService<IGameStateService>();
            _gameConfigService = serviceContainer.GetService<IGameConfigService>();
            _gameEntityService = serviceContainer.GetService<IGameEntityService>();
            _gameResourceService = serviceContainer.GetService<IGameResourceService>();
        }
    }
}