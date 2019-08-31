using System.Collections.Generic;
using Lockstep.Game;

namespace LockstepTutorial {
    public interface IEntityService : IService {
        void AddEntity<T>(T e) where T : class;
        void RemoveEntity<T>(T e) where T : class;
        List<T> GetEntities<T>();
    }
}