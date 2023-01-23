<script lang="ts">
	import { getContext } from 'svelte';
	import { fly } from 'svelte/transition';
	import PopupContent from './PopupContent.svelte';
	import CloseButton from './CloseButton.svelte';
	import type { Entry } from '$lib/ts/entry';

	export let data: Entry;

	const { open }: any = getContext('simple-modal');

	const openPopup = () =>
		open(
			PopupContent,
			{ data: data },
			{
				unstyled: true,
				closeButton: CloseButton,
				styleWindow: {
					background: 'var(--background-secondary);',
					minWidth: '70%',
					maxWidth: '100%',
					marginTop: '-1rem',
				},
				styleContent: {
					color: 'var(--text-primary);',
				},
				transitionWindow: fly,
				transitionWindowProps: {
					y: 50,
					duration: 300,
				},
			},
		);
</script>

<button on:click={openPopup}>Rediger</button>

<style lang="scss">
	button {
		background-color: var(--background-secondary);
		color: var(--text-primary);
		font-size: 0.75rem;
		border-radius: 5px;
		border: 2px solid var(--accent-primary);
		cursor: pointer;
		box-shadow: var(--box-shadow);
		transition: background-color 0.2s ease, color 0.2s linear;

		&:hover {
			background-color: var(--accent-primary);
			color: var(--accent-text);
		}
	}
</style>
