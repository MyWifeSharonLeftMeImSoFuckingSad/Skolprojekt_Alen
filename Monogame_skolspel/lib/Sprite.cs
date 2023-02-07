using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monogame_skolspel.lib
{
    public abstract class sprite {
        public Game game { get; set; }

        //public sprite(Game _game) { game = _game; }
        public Texture2D texture { get; set; }
        //public Texture2D textureRight { get; set; }
        public Vector2 position;
        public Vector2 position2;
        public int Health;

        //public sprite SetFollowTarget(sprite followTarget, float followDistance)
        //{
        //    FollowTarget = followTarget;
        //    FollowDistance = followDistance;
        //    return this;
        //}

        //protected void Follow()
        //{
        //    if (FollowTarget == null)
        //        return;

        //    var distance = FollowTarget.position - this.position;
        //    _rotation = (float)Math.Atan2(distance.Y, distance.X);
        //    Direction = new Vector2((float)Math.Cos(_rotation), (float)Math.Sin(_rotation));
        //    var currentDistance = Vector2.Distance(this.position, FollowTarget.position);
        //    if(currentDistance > FollowDistance)
        //    {
        //        var t = MathHelper.Min((float)Math.Abs(currentDistance - FollowDistance), LinearVelocity);
        //        var velocity = Direction * t;

        //        position += velocity;
        //    }
        //}

        //public float _layer { get; set; }
        //protected Vector2 _origin { get; set; }
        //protected Vector2 _position_test { get; set; }

        //protected float _rotation { get; set; }
        //public sprite FollowTarget { get; set; }

        //public float FollowDistance { get; set; }

        //public Vector2 Direction { get; set; }

        //public float LinearVelocity = 4f;

        //public float layer
        //{
        //    get { return _layer; }
        //    set { _layer = value; }
        //}

        //public Vector2 origin
        //{
        //    get { return _origin; }
        //    set { _origin = value; }
        //}

        //public Vector2 position_test
        //{
        //    get { return _position_test; }
        //    set { _position_test = value; }
        //}

        public virtual Color Color { get; set; } = Color.White;
        public int _speed { get; set;  } = 5;
        public bool IsActive { get; set; } = true;

        public virtual void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(texture, position, Color);
        }



        public abstract void Update();

    }

}
