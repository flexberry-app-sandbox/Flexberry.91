import {
  defineNamespace,
  defineProjections,
  Model as РегистрMixin
} from '../mixins/regenerated/models/i-i-s-9-регистр';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(РегистрMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
