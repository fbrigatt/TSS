using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuaraTattooSoft.Util
{
    public struct KeyValueTriple<TKey, TPrimaryValue, TSecondaryValue>
    {

        private TKey _key;
        private TPrimaryValue _primaryValue;
        private TSecondaryValue _secondaryValue;

        public KeyValueTriple(TKey key, TPrimaryValue primaryValue, TSecondaryValue secondaryValue)
        {
            _key = key;
            _primaryValue = primaryValue;
            _secondaryValue = secondaryValue;
        }

        #region Propriedades
        public TKey Key
        {
            get
            {
                return _key;
            }

            set
            {
                _key = value;
            }
        }

        public TPrimaryValue PrimaryValue
        {
            get
            {
                return _primaryValue;
            }

            set
            {
                _primaryValue = value;
            }
        }

        public TSecondaryValue SecondaryValue
        {
            get
            {
                return _secondaryValue;
            }

            set
            {
                _secondaryValue = value;
            }
        }
        #endregion
    }
}
