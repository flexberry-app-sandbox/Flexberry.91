import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-9-контрагент', 'Unit | Model | i-i-s-9-контрагент', {
  // Specify the other units that are required for this test.
  needs: [
    'model:i-i-s-9-должности',
    'model:i-i-s-9-записи',
    'model:i-i-s-9-заявка',
    'model:i-i-s-9-контрагент',
    'model:i-i-s-9-регистр',
    'model:i-i-s-9-сотрудник',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
    'service:syncer',
  ],
});

test('it exists', function(assert) {
  let model = this.subject();

  // let store = this.store();
  assert.ok(!!model);
});
