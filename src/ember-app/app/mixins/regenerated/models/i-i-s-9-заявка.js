import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  важност: DS.attr('string'),
  номЗаяв: DS.attr('string'),
  состоян: DS.attr('string'),
  текст: DS.attr('string'),
  контрагент: DS.belongsTo('i-i-s-9-контрагент', { inverse: null, async: false }),
  сотрудник: DS.belongsTo('i-i-s-9-сотрудник', { inverse: null, async: false })
});

export let ValidationRules = {
  важност: {
    descriptionKey: 'models.i-i-s-9-заявка.validations.важност.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  номЗаяв: {
    descriptionKey: 'models.i-i-s-9-заявка.validations.номЗаяв.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  состоян: {
    descriptionKey: 'models.i-i-s-9-заявка.validations.состоян.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  текст: {
    descriptionKey: 'models.i-i-s-9-заявка.validations.текст.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
  контрагент: {
    descriptionKey: 'models.i-i-s-9-заявка.validations.контрагент.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  сотрудник: {
    descriptionKey: 'models.i-i-s-9-заявка.validations.сотрудник.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ЗаявкаE', 'i-i-s-9-заявка', {
    номЗаяв: attr('Номер заяв', { index: 0 }),
    важност: attr('Важность', { index: 1 }),
    состоян: attr('Состояние', { index: 2 }),
    текст: attr('Текст', { index: 5 }),
    контрагент: belongsTo('i-i-s-9-контрагент', 'Контрагент', {

    }, { index: 3 }),
    сотрудник: belongsTo('i-i-s-9-сотрудник', 'Сотрудник', {

    }, { index: 4 })
  });

  modelClass.defineProjection('ЗаявкаL', 'i-i-s-9-заявка', {
    номЗаяв: attr('Номер заявки', { index: 0 }),
    важност: attr('Важность', { index: 1 }),
    состоян: attr('Состояние', { index: 2 }),
    текст: attr('Текст', { index: 5 }),
    контрагент: belongsTo('i-i-s-9-контрагент', 'Контрагент', {

    }, { index: 3 }),
    сотрудник: belongsTo('i-i-s-9-сотрудник', 'Сотрудник', {

    }, { index: 4 })
  });

  modelClass.defineProjection('ЗаявкаНаРаботыE', 'i-i-s-9-заявка', {
    текст: attr('Текст', { index: 0 }),
    важност: attr('', { index: 1 }),
    номЗаяв: attr('', { index: 2 }),
    состоян: attr('', { index: 3 }),
    контрагент: belongsTo('i-i-s-9-контрагент', '', {

    }, { index: 4 }),
    сотрудник: belongsTo('i-i-s-9-сотрудник', '', {

    }, { index: 5 })
  });

  modelClass.defineProjection('ЗаявкаНаРаботыL', 'i-i-s-9-заявка', {
    номЗаяв: attr('', { index: 0 }),
    состоян: attr('', { index: 1 }),
    важност: attr('', { index: 2 }),
    текст: attr('Текст', { index: 3 }),
    контрагент: belongsTo('i-i-s-9-контрагент', '', {

    }, { index: 4 }),
    сотрудник: belongsTo('i-i-s-9-сотрудник', '', {

    }, { index: 5 })
  });
};
